using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 720;
    public int score;
    public GameObject pickup;
    public GameObject manager;



    void Start()
    {

    }


    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector2 movementDirection = new Vector2(horizontalInput, verticalInput);
        movementDirection.Normalize();

        transform.Translate(movementDirection * speed * Time.deltaTime, Space.World);

        if (movementDirection != Vector2.zero)
        {
            Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDirection);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }

      

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="a")
        {
            Debug.Log("COLLISION!!!!");
           // Destroy(pickup);
            score = score + 1;
            manager.SetActive(true);

        }

        if (collision.gameObject.tag == "Putdown")
        {
            Debug.Log("Abgelegt");
        }



    }

}

