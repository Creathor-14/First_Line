using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telearañas : MonoBehaviour
{
    public float tiempo_start=0;//segundos de inicio
    public float tiempo_end;//segundos de fin
    
    private SpriteRenderer sr;
    
    public GameObject teleD;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject teleI;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
//Activar Objetos telearañas derecha o izquierda        
        if (!sr.flipX && sr.sprite.name == ("Invisible_0"))
        {
            teleD.gameObject.SetActive(true);
            tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
        }
        else
        {
            teleD.gameObject.SetActive(false);
            tiempo_start = 0;//Resetea los segundos de una funcion
        }
        
        if (sr.flipX && sr.sprite.name == ("Invisible_0"))
        {
            teleI.gameObject.SetActive(true);
        }
        else
        {
            teleI.gameObject.SetActive(false);
        }
   
//Mostrar Sprites
        if (teleD.gameObject.activeSelf)
        {
            a.gameObject.SetActive(true);
            if (tiempo_start >= 0.5)
            {
                a.gameObject.SetActive(false);
                b.gameObject.SetActive(true);
            }

            if (tiempo_start >= 1)
            {
                b.gameObject.SetActive(false);
                c.gameObject.SetActive(true);
            }

            if (tiempo_start >= 1.5)
            {
                c.gameObject.SetActive(false);
                d.gameObject.SetActive(true);
            }

            if (tiempo_start >= 2)
            {
                d.gameObject.SetActive(false);
            }
           
            
        }
    }
    
}