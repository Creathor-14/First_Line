using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGame : MonoBehaviour // unico metodo para salirse del juego(Aplicacíon)
{
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Ha salido del juego");
    }
}
