using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrido : MonoBehaviour
{
    private SpriteRenderer sr;
    private GameObject ladrarD;
    private GameObject ladrarI;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ladrarD = GameObject.FindGameObjectWithTag("LadridoD");
        ladrarI = GameObject.FindGameObjectWithTag("LadridoI");
    }

    // Update is called once per frame
    void Update()
    {
        if (sr.flipX)
        {
            ladrarD.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name==("matapaco (2)_1"))
            {
                ladrarI.GetComponent<SpriteRenderer>().enabled= true; 
            }
            else
            {
                ladrarI.GetComponent<SpriteRenderer>().enabled= false;
            }
            
        }
        else 
        {
            ladrarI.GetComponent<SpriteRenderer>().enabled= false;
            if (sr.sprite.name==("matapaco (2)_1"))
            {
                ladrarD.GetComponent<SpriteRenderer>().enabled= true; 
            }
            else
            {
                ladrarD.GetComponent<SpriteRenderer>().enabled= false;
            }
        }
        
    }
}
