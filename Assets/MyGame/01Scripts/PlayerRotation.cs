using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRotation : MonoBehaviour
{
    public float speed = 0.5f;
    public float rotationSpeed = 720;
    public int score;
    public Text displayText;


    public GameObject orange;
    public GameObject zitrone;
    public GameObject zimt;
    public GameObject zucker;
    public GameObject wein;
    public GameObject wasser;
    public GameObject rum;

    public GameObject panelwin;

    public GameObject bubbles;

    public Material change;

    public bool m = false;


    void Start()
    {
        change.color = Color.grey;
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

        if (score == 1)
        {
            zitrone.SetActive(true);
            bubbles.SetActive(true);
            change.color = Color.red;
        }

        if (score == 2)
        {
            zimt.SetActive(true);
            Destroy(zitrone);
            change.color = Color.yellow;

        }

        if (score == 3)
        {
            zucker.SetActive(true);
            Destroy(zimt);
            change.color = Color.red;
        }

        if (score == 4)
        {
            wein.SetActive(true);
            Destroy(zucker);
            change.color = Color.yellow;
        }

        if (score == 5)
        {
            wasser.SetActive(true);
            Destroy(wein);
            change.color = Color.red;
        }

        if (score == 6)
        {
            rum.SetActive(true);
            Destroy(wasser);
            change.color = Color.blue;
        }

        if (score == 7)
        {
            Destroy(rum);
            change.color = Color.red;
            panelwin.SetActive(true);
        }

        displayText.text = score.ToString();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="a")
        {
            Debug.Log("COLLISION!!!!");
             m = true;
    // Destroy(pickup);

}

        if (collision.gameObject.tag == "Putdown" && m==true)
        {
            Debug.Log("Abgelegt");
            Destroy(orange);
            OnDestroy();
            m = false;
        }

    }

    void OnDestroy()
    {
        score++;
    }


}



