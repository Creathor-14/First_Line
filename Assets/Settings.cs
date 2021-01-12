using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolumen(float volumeGeneral)
    {
        audioMixer.SetFloat("GeneralVolumen", volumeGeneral);
    }
    
}
