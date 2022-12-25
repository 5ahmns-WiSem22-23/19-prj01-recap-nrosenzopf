using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectPosition : MonoBehaviour
{
    private float maxX = 4;
    private float maxY = 4;

    void Start()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomY = Random.Range(-maxY, maxY);

        Vector3 randomPosition = new Vector3(randomX, randomY, 0);
        transform.position = randomPosition;
    }
}
