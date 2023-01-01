using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerDuration = 30.0f;
    public Text timerText;

    public GameObject loosePanel;

    private float elapsedTime = 0.0f;

    void Update()
    {
        elapsedTime += Time.deltaTime;

        float timeRemaining = timerDuration - elapsedTime;
        int minutes = (int)(timeRemaining / 60.0f);
        int seconds = (int)(timeRemaining % 60.0f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (timeRemaining <= 0.0f)
        {
            timerText.text = "0:00";
            loosePanel.SetActive(true);
        }
    }
}
