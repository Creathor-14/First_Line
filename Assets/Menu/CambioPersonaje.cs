using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioPersonaje : MonoBehaviour
{
    private GameObject[] cambiarP;
    private int index;

    void Start()
    {
        index = PlayerPrefs.GetInt("animation player");
        cambiarP = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
            cambiarP[i] = transform.GetChild(i).gameObject;

        foreach (GameObject objeto in cambiarP)
            objeto.SetActive(false);

        if (cambiarP[index])
            cambiarP[index].SetActive(true);

    }

    public void BotonDer()
    {
        cambiarP[index].SetActive(false);
        index++;
        if (index == cambiarP.Length)
            index = 0;
        cambiarP[index].SetActive(true);
    }
    
    public void BotonIzq()
    {
        cambiarP[index].SetActive(false);
        index--;
        if (index < 0)
            index = cambiarP.Length-1;
        cambiarP[index].SetActive(true);
    }

    public void PlayScene()
    {
        PlayerPrefs.SetInt("animation player",index);
        SceneManager.LoadScene("Nivel_1 luces");

    }
}
