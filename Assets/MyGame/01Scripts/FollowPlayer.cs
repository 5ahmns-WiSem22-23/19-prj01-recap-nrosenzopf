using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject ablage;


    private bool shouldFollow = false;

    void Update()
    {
        if (shouldFollow)
        {
            transform.position = player.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            shouldFollow = true;
        }


        if (other.gameObject.tag == "Putdown")
        {
            Debug.Log("Abgelegt");

        }
    }
}