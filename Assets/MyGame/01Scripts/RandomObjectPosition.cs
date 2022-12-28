using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectPosition : MonoBehaviour
{
    public GameObject pickup;

    // An array of objects with box colliders to avoid
    public GameObject[] objectsToAvoid;
    public Vector3 randomPosition;

    void Start()
    {
        // Keep generating random positions until a suitable one is found
       
        bool positionFound = false;
        while (!positionFound)
        {
            // Generate a random position within a certain range
            randomPosition = new Vector3(Random.Range(-3f, 3f), Random.Range(-2.5f, 2.5f), 0f);
            Debug.Log(randomPosition);


            // Check if the position is not colliding with any of the objects with box colliders
            positionFound = true;
            Debug.Log(positionFound);


            foreach (GameObject obj in objectsToAvoid)
            {
                BoxCollider2D collider = obj.GetComponent<BoxCollider2D>();
                if (collider.bounds.Contains(randomPosition))
                {
                    Debug.Log("Ready?");
                    positionFound = false;
                    break;
                }
            }

            
        }

        if (positionFound==true)
        {
            pickup.transform.position = randomPosition;
            Debug.Log("Jetzt erst");
        }
       
    }
}

