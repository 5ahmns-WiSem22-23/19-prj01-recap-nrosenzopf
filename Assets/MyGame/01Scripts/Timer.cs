using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timerDuration = 60.0f;
    public Text timerText;

    public GameObject loosePanel;

    private float eTime = 0.0f;

    void Update()
    {
        eTime += Time.deltaTime;

        float timeRemaining = timerDuration - eTime;
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
