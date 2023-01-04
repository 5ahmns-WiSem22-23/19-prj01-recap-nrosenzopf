using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TwentyWaiter : MonoBehaviour
{
    public float interval = 20f;
    public GameObject TimeGood;
    public GameObject TimeGood2;
    public TextMeshPro textField;
 

    void Start()
    {
        StartCoroutine(TimerCoroutine());
        StartCoroutine(ActivateCoroutine());
    }
    IEnumerator ActivateCoroutine()
    {
        while (true)
        {
            Debug.Log("AAAAAAAAA");
            yield return new WaitForSeconds(interval);
            TimeGood.SetActive(true);

            yield return new WaitForSeconds(interval);
            TimeGood2.SetActive(true);

            yield return new WaitForSeconds(interval);
        }
    }
    IEnumerator TimerCoroutine()
    {
        while (true)
        {
            for (int i = 20; i > 0; i--)
            {
                textField.text = i.ToString();
                yield return new WaitForSeconds(1.0f);
            }

            textField.text = "20";
        }
    }
   

}
