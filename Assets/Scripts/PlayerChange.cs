using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChange : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Camera cam;
    [SerializeField] private GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Area3")
        {
            Vector3 camPosition = new Vector3(-11.5f, 12.93f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(-15.12f, 8.64f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(0f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(6.63f, -1.42f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area4")
        {
            Vector3 camPosition = new Vector3(42.2f, 32.49f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(34.73f, 28.43f, 0);
            player.transform.position = playerPosition;

        }


        
        if (collision.gameObject.tag == "Area2")
        {
            Vector3 camPosition = new Vector3(22.54f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(16.58f, 0.35f, 0);
            player.transform.position = playerPosition;

        }
        
    }
}
