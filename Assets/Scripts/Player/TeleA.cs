using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleA : MonoBehaviour
{
    private SpriteRenderer sr;
    
    private GameObject teleD;
    private GameObject teleI;
    
    private GameObject a;
    private GameObject b;
    private GameObject c;
    private GameObject d;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        teleD = GameObject.FindWithTag("TeleDer");
        teleI = GameObject.FindWithTag("TelearañaI");
        a = GameObject.FindWithTag("0");
        b = GameObject.FindWithTag("1");
        c = GameObject.FindWithTag("2");
        d = GameObject.FindWithTag("3");


        /**
        if (!sr.flipX)
        {
            //teleI.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name == ("Invisible_0"))
            {
                teleD.GetComponent<SpriteRenderer>().enabled= true;
                
                a.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                a.GetComponent<SpriteRenderer>().enabled= false;
                
                b.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                b.GetComponent<SpriteRenderer>().enabled= false;
                
                c.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                c.GetComponent<SpriteRenderer>().enabled= false;
                
                d.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                d.GetComponent<SpriteRenderer>().enabled= false;
                
                teleD.GetComponent<SpriteRenderer>().enabled= false;
            }
        }
        **/
        
        
        
    }

    private void Update()
    {
        if (!sr.flipX)
        {
            //teleI.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name == ("Invisible_0"))
            {
                teleD.GetComponent<SpriteRenderer>().enabled= true;
                
                a.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                a.GetComponent<SpriteRenderer>().enabled= false;
                
                b.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                b.GetComponent<SpriteRenderer>().enabled= false;
                
                c.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                c.GetComponent<SpriteRenderer>().enabled= false;
                
                d.GetComponent<SpriteRenderer>().enabled= true;
                StartCoroutine("Esperar");
                d.GetComponent<SpriteRenderer>().enabled= false;
                
                teleD.GetComponent<SpriteRenderer>().enabled= false;
            }
        }
    }

    /**
    void Update()
    {
        if (sr.flipX)
        {
            teleD.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name==("Invisible_0"))
            {
                a.GetComponent<SpriteRenderer>().enabled= true; 
            }
            else
            {
                teleI.GetComponent<SpriteRenderer>().enabled= false;
            }
            
        }
        else 
        {
            teleI.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name==("Invisible_0"))
            {
                teleD.GetComponent<SpriteRenderer>().enabled= true; 
            }
            else
            {
                teleD.GetComponent<SpriteRenderer>().enabled= false;
            }
        }
    }
**/
    
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(1);
    }
}

