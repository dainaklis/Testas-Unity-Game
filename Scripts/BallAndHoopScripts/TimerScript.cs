using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    private Image timerBar;
    [SerializeField] float maxTime = 5f;
    private float timerLeft;
    [SerializeField] GameObject timesUpText;
    [SerializeField] Text timesUpScore;

    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timerLeft = maxTime;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerLeft > 0)
        {
            timerLeft -=Time.deltaTime;
            timerBar.fillAmount = timerLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            timesUpScore.text = "Your Score: " + DestroyZoneAndScoreAdd.instance.ScoreText();
            Time.timeScale = 0;
        }
    }
}
