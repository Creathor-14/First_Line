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
    public int tipo;
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
        int minimo=0;
        int maximo=0;
        if (tipo == 1)
        {
            minimo = 5;
            maximo = 10;
        }

        if (tipo == 2)
        {
            minimo = 10;
            maximo = 5;
        }
        
        //yield return new WaitForSeconds(betweenLightFlickers);
        myLight.pointLightOuterRadius = minimo;
        yield return new WaitForSeconds(2);
        myLight.pointLightOuterRadius = maximo;
        yield return new WaitForSeconds(2);
        //myLight.pointLightOuterRadius = UnityEngine.Random.Range(lightFlickerMin,lightFlickerMax);  // El random determinara el radio de iluminacion de la luz
        //myLight.pointLightOuterRadius = BarraVida.fillAmount*lightFlickerMin; 
        myLight.intensity = BarraVida.fillAmount; // se llama a la barra de vida y con el valor del fillamount que se obtenga, variara la intensidad de la luz
        
        
        StartCoroutine(LightFlicker());
        
        
    }
}


