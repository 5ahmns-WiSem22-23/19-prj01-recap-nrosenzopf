using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartControll : MonoBehaviour
{
    public GameObject panel;
    public GameObject player;
    public GameObject timer;
    public GameObject timeGood;

    public void OnButtonClick()
    {
        panel.SetActive(false);
        Debug.Log("Scheisse");
    }
 
 public void PlayerAktivieren()
    {
        player.SetActive(true);
        timer.SetActive(true);
        timeGood.SetActive(true);
    }
}
