using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform Player;
    public GameObject pickup;



    private void Update()
    {
        Player.transform.position = new Vector3(Player.position.x, Player.position.y, Player.transform.position.z);
    }
}
