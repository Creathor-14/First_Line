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
    

    void btnResume()
    {
        menuP.SetActive(false);
        Time.timeScale = 1;
        panel = false;
    }
    
    void btnPause()
    {
        menuP.SetActive(true);
        Time.timeScale = 0;
        panel = true;
    }
    
    public void panelQuit()
    {
        menuSalir.SetActive(true);
    }
    
    public void backYES()
    {
        SceneManager.LoadScene("Menu");
        menuP.SetActive(false);
        menuSalir.SetActive(false);
        panel = false;
        
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
