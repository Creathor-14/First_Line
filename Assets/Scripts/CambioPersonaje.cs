using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioPersonaje : MonoBehaviour
{
    private GameObject[] cambiarP; // se tiene una lista de personajes
    private int index;  // cada personaje tiene un indice

    void Awake()
    {
        index = PlayerPrefs.GetInt("animation player"); //obtiene una animacion(los personajes en IDLE)
        cambiarP = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)  // guarda a los personajes en un contenedor(lista de objetos)
            cambiarP[i] = transform.GetChild(i).gameObject;

        foreach (GameObject objeto in cambiarP)// desactiva a los demas personajes de la lista mientras uno este activo
            objeto.SetActive(false);

        if (cambiarP[index]) // si ese objeto esta seleccionado que muestre su animacion en la pantalla
            cambiarP[index].SetActive(true);

    }

    public void BotonDer() // se cambia al personaje de la derecha
    {
        cambiarP[index].SetActive(false);
        index++;
        if (index == cambiarP.Length)
            index = 0;
        cambiarP[index].SetActive(true);
    }
    
    public void BotonIzq()  // se cambia al personaje de la izquierda
    {
        cambiarP[index].SetActive(false);
        index--;
        if (index < 0)
            index = cambiarP.Length-1;
        cambiarP[index].SetActive(true);
    }

    public void PlayScene()  // manda al jugador al juego
    {
        PlayerPrefs.SetInt("animation player",index);
        SceneManager.LoadScene("Nivel_1 luces");

    }
}
