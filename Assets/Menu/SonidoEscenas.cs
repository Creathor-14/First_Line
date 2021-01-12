using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SonidoEscenas : MonoBehaviour
{
    public AudioMixer audioMixer;
    private SonidoEscenas instance;
    public SonidoEscenas Intance
    {
        get{
            return instance;
        }
    }

    private void Awake()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
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
    
    public void SetVolumen(float volumeGeneral)
    {
        audioMixer.SetFloat("GeneralVolumen", volumeGeneral);
    }
}
