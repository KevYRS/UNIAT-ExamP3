using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour{
    // Start is called before the first frame update

    private Vector2 moveDirection;
    [SerializeField] private float moveSpeed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Animator anim;

    private int Contador;
    public TextMeshProUGUI txtContador;


    AudioSource sonidosJuego;
    public AudioClip gema;

    public GameObject WinLose;
    public GameObject Win;
    public GameObject Lose;
    private PlayerHealth playerHealth;

    void Start(){
        Contador = 0;
        sonidosJuego = GetComponent<AudioSource>();
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(false);
        WinLose.gameObject.SetActive(false);
        playerHealth = FindObjectOfType<PlayerHealth>();
    }

    // Update is called once per frame
    void Update(){
        txtContador.text = "" + Contador; //score
        Movement();
        Animation();

        if (playerHealth.HealthCount == 0){
            ActivateLoseScreen();
        }

        if (Contador == 4){
            ActivateWinScreen();
        }
    }

    private void Movement(){

        if (WinLose.activeSelf){
            rb.velocity = Vector2.zero;
            return;
        }

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

    private void Animation(){
        anim.SetFloat("moveX", moveDirection.x);
        anim.SetFloat("moveY", moveDirection.y);
    }

    private void ActivateLoseScreen(){
        WinLose.gameObject.SetActive(true);
        Win.gameObject.SetActive(false);
        Lose.gameObject.SetActive(true);

        StopAllSlimes();
    }

    private void ActivateWinScreen(){
        WinLose.gameObject.SetActive(true);
        Lose.gameObject.SetActive(false);
        Win.gameObject.SetActive(true);

        StopAllSlimes();
    }

    private void StopAllSlimes(){
        SlimeBehavior[] slimes = FindObjectsOfType<SlimeBehavior>();
        foreach (var slime in slimes){
            slime.enabled = false; // Disable the SlimeBehavior script
        }
    }

    private void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.CompareTag("gema")){
            //anillo.gameObject.SetActive(false);

            Destroy(other.gameObject);
            Contador += 1;
            sonidosJuego.PlayOneShot(gema);
        }
        
    }
}