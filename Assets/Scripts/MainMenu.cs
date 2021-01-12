using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class MainMenu : MonoBehaviour
{

    public void PlayerSelect()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadGame");
    }

    public void Tips()
    {
        SceneManager.LoadScene("Tips");
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Ha salido del juego");
    }
}
