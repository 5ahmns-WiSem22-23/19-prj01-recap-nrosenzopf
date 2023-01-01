using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    public Transform player;
    public float speed = 5.0f;
    public Timer timer;

    void Update()
    {
        // Follow the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        Debug.Log("GATZEEEE!");
        timer.timerDuration = timer.timerDuration - 20;
        Destroy(this);
    }
}


