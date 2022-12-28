using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoEscenas : MonoBehaviour // Aca lo unico que pasa es que la musica no se corte al pasar a otra escena
{
    private SonidoEscenas instance;
    
    public SonidoEscenas Intance
    {
        get{
            return instance;
        }
    }

    private void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1) // si la escena es mayor que la principal, que el sonido siga funcionando
        {
            Destroy(gameObject);
        }

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        
        DontDestroyOnLoad(gameObject);
    }
}
