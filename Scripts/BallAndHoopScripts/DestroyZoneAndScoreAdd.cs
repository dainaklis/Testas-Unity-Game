using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyZoneAndScoreAdd : MonoBehaviour
{   
    public static DestroyZoneAndScoreAdd instance;
    [SerializeField] Text scoreText;
    [SerializeField] Text hightScoreText;
    private int score;
    private int highScore;


    private void Awake() 
    {
        instance = this;
    }

    private void Start() 
    {
       highScore = PlayerPrefs.GetInt("highScore", 0);
       hightScoreText.text = "Hight Score: " + highScore;
    }

    private void OnTriggerEnter2D(Collider2D col) 
    {
        SoundManager.PlaySound("points");
        Destroy(col.gameObject);
        score++;
        if (highScore < score)
        {
           PlayerPrefs.SetInt("highScore", score); 
        }
        
        scoreText.text = "Score: " + score;
        
    }

    public int ScoreText()
    {
        return score;
    }
}
