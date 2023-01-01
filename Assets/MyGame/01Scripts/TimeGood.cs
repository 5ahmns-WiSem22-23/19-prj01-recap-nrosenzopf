using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGood : MonoBehaviour
{
    public Timer timer;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            Debug.Log("Moooooore!");
        timer.timerDuration = timer.timerDuration + 20;
        Destroy(this);
    }
}
