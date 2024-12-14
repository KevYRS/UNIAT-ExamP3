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
            Vector3 camPosition = new Vector3(-15.58f, 4.63f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(-12.16f, 1.98f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area1")
        {
            Vector3 camPosition = new Vector3(0f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(6.63f, -1.42f, 0);
            player.transform.position = playerPosition;

        }



        if (collision.gameObject.tag == "Area1.1")
        {
            Vector3 camPosition = new Vector3(0f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(-5.32f, 0.81f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area1.2")
        {
            Vector3 camPosition = new Vector3(0f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(0.49f, -2.92f, 0);
            player.transform.position = playerPosition;

        }

        if (collision.gameObject.tag == "Area4")
        {
            Vector3 camPosition = new Vector3(42.2f, 32.49f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(34.73f, 28.43f, 0);
            player.transform.position = playerPosition;

        }

        if (collision.gameObject.tag == "Area4.1")
        {
            Vector3 camPosition = new Vector3(42.2f, 32.49f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(45.7f, 34.4f, 0);
            player.transform.position = playerPosition;

        }



        if (collision.gameObject.tag == "Area2")
        {
            Vector3 camPosition = new Vector3(22.54f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(16.58f, 0.35f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area2.2")
        {
            Vector3 camPosition = new Vector3(22.54f, 0f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(20.15f, 0.6f, 0);
            player.transform.position = playerPosition;

        }


        if (collision.gameObject.tag == "Area5")
        {
            Vector3 camPosition = new Vector3(0.95f, -26.13f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(7.2f, -23.4f, 0);
            player.transform.position = playerPosition;

        }



        if (collision.gameObject.tag == "Area6")
        {
            Vector3 camPosition = new Vector3(43.65f, 57.17f, -10);
            cam.transform.position = camPosition;


            Vector3 playerPosition = new Vector3(43.9f, 55.2f, 0);
            player.transform.position = playerPosition;

        }

    }
}
