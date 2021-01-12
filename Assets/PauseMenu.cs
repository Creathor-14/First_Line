using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject menuP, menuSalir;

    void Start()  // Ambos paneles comienzan desactivados
    {
        menuP.SetActive(false);
        menuSalir.SetActive(false);
    }

    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))  // si apretamos el boton escape o el boton de pausa entramos en el menu de pausa
        {
            if (gamePaused)  
            {
                Resume(); // si el juego esta pausado permite la opcion de continuar con el juego
            }
            else
            {
                Pause();  // si el juego esta corriendo permite la opcion abrir el menu de pausa
            }
        }
    }
    

    public void Resume() //continua con el juego
    {
        menuP.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }
    
    public void Pause() // se abre el menu de pausa
    {
        menuP.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    
    public void panelQuit() // despliega un mini menu donde vuelve a preguntarle al usuario si esta seguro de volver al menuMain
    {
        menuSalir.SetActive(true);
    }
    
    public void backYES() // se cierran todos los paneles y se envia al usuario al menu principal
    {
        menuP.SetActive(false);
        menuSalir.SetActive(false);
        gamePaused = false;
        SceneManager.LoadScene("Menu");

    }

    public void OptionsScene() // envia al usuario al menu de opciones
    {
        SceneManager.LoadScene("Options");
    }

    public void backNo() // deja al usuario en el menu de gameOVER porque no quizo volver al menu principal
    {
        menuSalir.SetActive(false);
    }

}
