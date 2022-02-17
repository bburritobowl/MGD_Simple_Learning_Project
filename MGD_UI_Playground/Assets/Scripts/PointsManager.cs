using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsManager : MonoBehaviour
{
    public static int highScore;
    private string HighScore =  "HighScore";
    private int score = 0;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        highScoreText.text = "Highscore: " + PlayerPrefs.GetInt(HighScore);
    }
    public void onClick()
    {
        score++;
        scoreText.text = "Score: " + score;
        if(PlayerPrefs.GetInt(HighScore) < score)
        {
            PlayerPrefs.SetInt(HighScore, score);
            highScoreText.text = "Highscore: " + PlayerPrefs.GetInt(HighScore);
        }
    }
}
