using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] RawImage[] hearts;
    private int healthCount = 3;
    //public TextMeshProUGUI perdiste;

    void Start()
    {
       // perdiste.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {

        switch (healthCount)
        {

            case 0:
                hearts[0].GetComponent<RawImage>().enabled = false;
                break;

            case 1:
                hearts[1].GetComponent<RawImage>().enabled = false;
                break;

            case 2:
                hearts[2].GetComponent<RawImage>().enabled = false;
                break;

        }

        if (healthCount == 0)
        {
           // perdiste.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")

        {
            healthCount--;
        }
    }
}
