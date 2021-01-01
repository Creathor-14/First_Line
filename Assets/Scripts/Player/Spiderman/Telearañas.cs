using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telearañas : MonoBehaviour
{
    public GameObject Spiderman;
    public float tiempo_start=0;//segundos de inicio
    
    private SpriteRenderer sr;
    
    public GameObject teleD;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    public GameObject teleI;
    public GameObject a1;
    public GameObject b1;
    public GameObject c1;
    public GameObject d1;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
//Tiempo para activar la telearaña
        if (sr.sprite.name == ("Invisible_0"))
        {
            tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
        }
        else
        {
            tiempo_start = 0;
        }
        
//Activar Objetos telearañas derecha o izquierda        
        if (!sr.flipX && sr.sprite.name == ("Invisible_0"))
        {
            teleD.gameObject.SetActive(true);
            
        }
        else
        {
            teleD.gameObject.SetActive(false);
            
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
    //Derecha
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
                Spiderman.transform.position += Vector3.right * 2f;
            }
        }
    //Izquierda
    if (teleI.gameObject.activeSelf)
    {
        a1.gameObject.SetActive(true);
        if (tiempo_start >= 0.5)
        {
            a1.gameObject.SetActive(false);
            b1.gameObject.SetActive(true);
        }

        if (tiempo_start >= 1)
        {
            b1.gameObject.SetActive(false);
            c1.gameObject.SetActive(true);
        }

        if (tiempo_start >= 1.5)
        {
            c1.gameObject.SetActive(false);
            d1.gameObject.SetActive(true);
        }

        if (tiempo_start >= 2)
        {
            d1.gameObject.SetActive(false);
            Spiderman.transform.position += Vector3.left * 2f;
        }
    }
    
    
    }
    
}