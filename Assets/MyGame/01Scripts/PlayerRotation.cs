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

    public GameObject timer;
    public GameObject panelwin;
    public GameObject menschen;
    public CameraZoomer camerazommerscript;
    public GameObject playeer;
    public GameObject timofTheGame;

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
          //  timer.SetActive(true);
        }

        if (score == 5)
        {
            wasser.SetActive(true);
            Destroy(wein);
            change.color = Color.red;
         //   timer.SetActive(false);
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
            menschen.SetActive(true);
            camerazommerscript.zoomIn = true;
            playeer.SetActive(false);
            speed = 0;
            timofTheGame.SetActive(false);
            StartCoroutine(ActivateCoroutine());



        }

        displayText.text = score.ToString();

    }

    IEnumerator ActivateCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(7);
            panelwin.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="a")
        {
            Debug.Log("COLLISION!!!!");
             m = true;

}

        if (collision.gameObject.tag == "Putdown" && m==true)
        {
            Debug.Log("Abgelegt");
            Destroy(orange);
            OnDestroy();
            m = false;
            speed = 4f;
        }

    }

    void OnDestroy()
    {
        score++;
    }


}



