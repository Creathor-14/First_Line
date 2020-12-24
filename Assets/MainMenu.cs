using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PlayerSelect()
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void StarGame()
    {
        SceneManager.LoadScene("Golpes");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadGame");
    }
    
    public void Options()
    {
        SceneManager.LoadScene("Options");
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
