using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
using Random=UnityEngine.Random;

public class Iluminacion_Global : MonoBehaviour
{
    
    Light2D myLight;

    public Image BarraVida;
    

    private void Start()
    {
        myLight = GetComponent<Light2D>();
        myLight.intensity = BarraVida.fillAmount;
        
    
    }

    
}
