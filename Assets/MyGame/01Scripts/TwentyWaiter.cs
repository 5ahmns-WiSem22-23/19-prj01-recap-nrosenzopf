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
    // Use this for initialization
    void Start()
    {
        // Starte die Coroutine zur wiederholten Aktivierung
        StartCoroutine(ActivateCoroutine());
    }

    public void Update()
    {
        textField.text = interval.ToString();
    }

    // Die Coroutine zur wiederholten Aktivierung
    IEnumerator ActivateCoroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);
            // Aktiviere das GameObject
            TimeGood.SetActive(true);

            // Warte die festgelegte Zeit
            yield return new WaitForSeconds(interval);

            // Deaktiviere das GameObject
            TimeGood2.SetActive(false);

            // Warte erneut die festgelegte Zeit
            yield return new WaitForSeconds(interval);
        }
    }

}
