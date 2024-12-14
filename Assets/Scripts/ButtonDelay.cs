using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private GameObject buttonDelay;
    [SerializeField] private int time = 0;
    [SerializeField] private GameObject puerta;

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Player")
        {
            StartCoroutine(ActivateButton(time));
        }
    }
    IEnumerator ActivateButton(int time)
    {
        buttonDelay.SetActive(false);
        puerta.SetActive(false);
        yield return new WaitForSeconds(time);
        buttonDelay.SetActive(true);
        puerta.SetActive(true);
    }
}
