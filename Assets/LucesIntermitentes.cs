using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
using Random=UnityEngine.Random;

public class LucesIntermitentes : MonoBehaviour
{
    [SerializeField] private float betweenLightFlickers;
    [SerializeField] private float lightFlickerMin;
    [SerializeField] private float lightFlickerMax;
    [SerializeField] private float beginningTime;
    Light2D myLight;

    public Image BarraVida;
    

    private void Start()
    {
        myLight = GetComponent<Light2D>();
        StartCoroutine(StartScene());
        
    
}

    IEnumerator StartScene()
    {
        yield return new WaitForSeconds(beginningTime);  // variable tiempo de parpadeo
        StartCoroutine(LightFlicker());
    }

    IEnumerator LightFlicker()
    {
        yield return new WaitForSeconds(betweenLightFlickers); // 
        myLight.pointLightOuterRadius = Random.Range(lightFlickerMin,lightFlickerMax);  // El random determinara el radio de iluminacion de la luz
        //myLight.pointLightOuterRadius = BarraVida.fillAmount*lightFlickerMin; 
        myLight.intensity = BarraVida.fillAmount; // se llama a la barra de vida y con el valor del fillamount que se obtenga, variara la intensidad de la luz
        StartCoroutine(LightFlicker());
    }
}
