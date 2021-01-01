using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Telearañas : MonoBehaviour
{
    private SpriteRenderer sr;
    
    public GameObject teleD;

    public GameObject teleI;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}