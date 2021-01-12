using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour // aqui cada public void (metodos) te envia a la escena que tienen escrita
{
    public void PlayerSelect()  // envia al usuario a la escena para seleccionar personajes
    {
        SceneManager.LoadScene("PlayerSelection");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("LoadGame");
    }
    
    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    
    public void Tips() // escena de pistas
    {
        SceneManager.LoadScene("Tips");
    }

    public void BackMenu() // te regresa al menu
    {
        SceneManager.LoadScene("Menu");
    }

    public void ExitGame() // solo suelta un mensaje aun falta configurarlo
    {
        Application.Quit();
        Debug.Log("Ha salido del juego");
    }
}
