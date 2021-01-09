using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject Gameover;
    public static GameOver gameover;
    public GameObject menuSalir, menuP;
    void Start()
    {
        gameover = this;
        menuP.SetActive(false);
        menuSalir.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CallGameOver()
    {
        Gameover.SetActive(true);
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
        

    }

    public void backNo()
    {
        menuSalir.SetActive(false);
    }
}
