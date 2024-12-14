using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour{
    public GameObject pauseMenuCanvas; // Canvas del menú de pausa
    private bool isPaused = false;

    AudioSource sonidosJuego;
    public AudioClip pausa;


    void Start(){

        sonidosJuego = GetComponent<AudioSource>();

    }
    void Update(){
        // Alternar el menú de pausa con la tecla Escape
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (isPaused){
                ResumeGame();
                
            }
            else{
                PauseGame();
              
            }
        }
    }
    public void PauseGame(){
        isPaused = true;
        sonidosJuego.PlayOneShot(pausa);
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f; // Pausar el tiempo del juego
        
    }
    public void ResumeGame(){
        isPaused = false;
        pauseMenuCanvas.SetActive(false);
        sonidosJuego.PlayOneShot(pausa);
        Time.timeScale = 1f; // Reanudar el tiempo del juego

    }
    public void RestartLevel(){
        Time.timeScale = 1f; // Asegurarse de que el tiempo está normal
        SceneManager.LoadScene("Level01"); // Reiniciar la escena actual
    }
    public void GoToTitleScreen(){
        Time.timeScale = 1f; // Asegurarse de que el tiempo está normal
        SceneManager.LoadScene("TitleScreen"); // Cambiar a la escena de título
    }
    public void Salir(){
        Application.Quit();
        Debug.Log("salio del juego");
    }
}