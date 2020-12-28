using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrido : MonoBehaviour
{
    private SpriteRenderer sr;
    private GameObject ladrar;

    
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ladrar = GameObject.FindGameObjectWithTag("Ladrido");
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (sr.sprite.name==("matapaco (2)_1"))
        {
            ladrar.GetComponent<SpriteRenderer>().enabled= true; 
        }
        
            
        
        else
        {
            ladrar.GetComponent<SpriteRenderer>().enabled= false;
        }
    }
}
