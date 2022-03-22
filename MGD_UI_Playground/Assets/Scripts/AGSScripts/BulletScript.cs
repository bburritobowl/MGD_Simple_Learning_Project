using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5000f;

    AGSGameManagerScript gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<AGSGameManagerScript>();

        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector2(0f, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Ship")
        Destroy(other.gameObject); //Boom go the meteors
        gameManager.AddScore(); //add score
        Destroy(gameObject); //bullet go bye
    }
}
