using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AGSGameManagerScript : MonoBehaviour
{
    public GameObject spaceShip;
    public Text scoreText;
    public Text gameOverText;
    // public Text runtimeText;
    int playerScore = 0;
    public float speed = -2f;
    //public float runtime = 0f;
    // float meteorSpeedTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(spaceShip)
        // {
            // runtime += Time.deltaTime;
            // runtimeText.text = "Time: " + runtime.ToString();
        // }

        // meteorSpeedTimer += Time.deltaTime;

        // if(meteorSpeedTimer == 5f)
        // {
            // speed += speed * 2;
            // meteorSpeedTimer = 0f;
        // }
    }

    public void AddScore()
    {
        playerScore++;
        scoreText.text = "Score: " + playerScore.ToString();
    }

    public void PlayerDied()
    {
        gameOverText.gameObject.SetActive(true);
        Time.timeScale = 0; //This freezes the game
    }
}
