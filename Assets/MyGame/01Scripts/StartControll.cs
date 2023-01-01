using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControll : MonoBehaviour
{
    public GameObject panel;

    public void OnButtonClick()
    {
        panel.SetActive(false);
        Debug.Log("Scheisse");
    }
 
 
}
