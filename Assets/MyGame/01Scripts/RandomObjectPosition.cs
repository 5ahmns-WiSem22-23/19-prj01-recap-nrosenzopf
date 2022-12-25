using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectPosition : MonoBehaviour
{
    public float maxX = 5;
    public float maxY = 5;

    void Start()
    {
        float randomX = Random.Range(-maxX, maxX);
        float randomY = Random.Range(-maxY, maxY);

        Vector3 randomPosition = new Vector3(randomX, randomY, 0);
        transform.position = randomPosition;
    }
}
