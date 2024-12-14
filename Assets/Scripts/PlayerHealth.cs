using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour{
    // Start is called before the first frame update

    [SerializeField] RawImage[] hearts;
    private int healthCount = 5;
    //public TextMeshProUGUI perdiste;

    AudioSource sonidosJuego;
    public AudioClip hit;

    void Start(){
        // perdiste.gameObject.SetActive(false);
        sonidosJuego = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update(){

        switch (healthCount){
            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
                break;

            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
                break;

            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
                break;

            case 3:
                hearts[3].GetComponent<RawImage>().enabled = false;
                break;

            case 4:
                hearts[4].GetComponent<RawImage>().enabled = false;
                break;

        }
        if (healthCount == 0){
           // perdiste.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Enemy"){
            healthCount--;
            sonidosJuego.PlayOneShot(hit);
        }
    }
}