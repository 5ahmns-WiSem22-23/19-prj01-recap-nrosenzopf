using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomer : MonoBehaviour
{
    public bool zoomIn=false;
    public Camera camera;
    public float zoomAmount = 1.0f;

    void Update()
    {
        if (zoomIn)
        {
            camera.orthographicSize -= zoomAmount;
        }
    }
}
