using System;
using UnityEngine;
using UnityEngine.UI;

public class LOAD: MonoBehaviour
{
    public static bool carga;
    public Button b;

    private void Start()
    {
        b.interactable = PlayerPrefs.GetFloat("Player x") != null && PlayerPrefs.GetFloat("Player y") != null;
    }

    public void Cargar()
    {
        Debug.Log("Cargado");
        Application.LoadLevel(2);
        carga = true;
    }
    
    public void NoCargar()
    {
        Debug.Log("Bloqueado");
        carga = false;
        Application.LoadLevel(2);
    }
}