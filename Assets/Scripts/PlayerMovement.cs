using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Vector2 moveDirection;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;

    private int Contador;
    public TextMeshProUGUI txtContador;


    AudioSource sonidosJuego;
    public AudioClip gema;

    void Start()
    {
        Contador = 0;
        sonidosJuego = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        txtContador.text = "" + Contador; //score
        Movement();
        Animation();
    }


    private void Movement()

    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized;

        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }


    private void Animation()

    {
        anim.SetFloat("moveX", moveDirection.x);
        anim.SetFloat("moveY", moveDirection.y);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("gema"))
        {
            //anillo.gameObject.SetActive(false);

            Destroy(other.gameObject);
            Contador += 1;
             sonidosJuego.PlayOneShot(gema);
        }
        
    }
}
