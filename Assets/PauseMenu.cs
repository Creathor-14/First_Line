using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool panel;
    public GameObject menuP, menuSalir;

    void Start()
    {
        menuP.SetActive(false);
        menuSalir.SetActive(false);
    }

    public void Switch() 
    {
        if (panel)
        {
            btnResume();
        }
        else
        {
            btnPause();
        }

    }
    

    void btnResume() //continua con el juego
    {
        menuP.SetActive(false);
        Time.timeScale = 1;
        panel = false;
    }
    
    void btnPause() // se abre el menu de pausa
    {
        menuP.SetActive(true);
        Time.timeScale = 0;
        panel = true;
    }
    
    public void panelQuit() // despliega un mini menu donde vuelve a preguntarle al usuario si esta seguro de volver al menuMain
    {
        menuSalir.SetActive(true);
    }
    
    public void backYES()
    {
        menuP.SetActive(false);
        menuSalir.SetActive(false);
        panel = false;
        SceneManager.LoadScene("Menu");

    }

    public void OptionsScene()
    {
        SceneManager.LoadScene("Options");
    }

    public void backNo()
    {
        menuSalir.SetActive(false);
    }

}
