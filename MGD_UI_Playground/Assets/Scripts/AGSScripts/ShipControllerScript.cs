using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipControllerScript : MonoBehaviour
{
    public AGSGameManagerScript gameManager;
    public GameObject bulletPrefab;
    public GameObject doubleBulletPrefab;
    public float speed = 10f;
    public float xLimit = 7f;
    public float reloadTime = 0.5f;
    float elapsedTime = 0f;

    public GameObject spawnPos;
    public int health = 3;
    public Text healthText;
    public Text shieldTimeText;
    public bool shield = false;
    float shieldTime = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keeping track of time for bullet firing
        elapsedTime += Time.deltaTime;

        //Move player left and right
        // float xInput = Input.GetAxis("Horizontal");
        // transform.Translate(xInput * speed * Time.deltaTime, 0f, 0f);

        //Clamp ship's X position
    //    Vector3 position = transform.position;
    //    position.x = Mathf.Clamp(position.x, -xLimit, xLimit);
    //    transform.position = position;

        //Spacebar fires if enough time between shots
        if(Input.GetButtonDown("Fire1") && elapsedTime > reloadTime)
        {
            //Instantiate the bullet 1.2 units in front of the player
            // Vector3 spawnPos = transform.position;
            // spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos.transform.position, Quaternion.identity);

            elapsedTime = 0f; //Reset timer
        }
        if(Input.GetButtonDown("Fire2") && elapsedTime > reloadTime) //doubleshot when t is pressed
        {
            //Instantiate the bullet 1.2 units in front of the player
            // Vector3 spawnPos = transform.position;
            // spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(doubleBulletPrefab, spawnPos.transform.position, Quaternion.identity);

            elapsedTime = 0f; //Reset timer
        }
        // if(Input.GetButtonDown("Fire3") && elapsedTime > reloadTime) //random multi-shot when r is pressed
        // {        
            // int numOfBullets = Random.Range(5, 10);
            // for(int i = 0; i < numOfBullets; i++)
            // {
                // Instantiate(bulletPrefab, new Vector3(transform.position.x + (i - (numOfBullets / 2)) * 0.2f, transform.position.y - 
                // Mathf.Abs((i - (numOfBullets / 2)) * 0.2f) + 1), Quaternion.identity);
            // }
            // elapsedTime = 0f;
        // }

        //Start the shield timer
        if(shield)
        {
            shieldTimeText.gameObject.SetActive(true);
            shieldTime -= Time.deltaTime;
            shieldTimeText.text = "Shield Time Remaining: " + shieldTime.ToString();

            if(shieldTime <= 0)
            {
                shield = false;
                shieldTime = 10f;
                shieldTimeText.gameObject.SetActive(false);
            }
        }
    }

    //If meteor collides with player

    void FixedUpdate()
    {
        healthText.text = "Lives: " + health.ToString();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Meteor" && !shield)
        {
            health--;

            if(health <= 0)
            {
                gameManager.PlayerDied();
            }
        }
        else if(other.gameObject.tag == "ShieldMeteor")
        {
            shield = true;
        }
        Destroy(other.gameObject);
    }
}
