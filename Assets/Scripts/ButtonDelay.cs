using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDelay : MonoBehaviour
{
    [SerializeField] private GameObject buttonDelay;
    [SerializeField] private int time = 0;
    [SerializeField] private GameObject puerta;

    AudioSource sonidosJuego;
    public AudioClip cofreabrir;
    public AudioClip cofrecerrar;

    void Start()
    {

        sonidosJuego = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.tag == "Player")
        {
            StartCoroutine(ActivateButton(time));
            sonidosJuego.PlayOneShot(cofreabrir);
        }
    }
    IEnumerator ActivateButton(int time)
    {
        buttonDelay.SetActive(false);
        puerta.SetActive(false);
        sonidosJuego.Stop();
        yield return new WaitForSeconds(time);
        sonidosJuego.PlayOneShot(cofrecerrar);
        buttonDelay.SetActive(true);
        puerta.SetActive(true);
    }
}
