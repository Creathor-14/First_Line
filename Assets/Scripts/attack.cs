using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    
    private Rigidbody2D pRB;
    public float BumpX, BumpY;
    
    void Start()
    {
        pRB = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemi")
        {
            GetComponent<SpriteRenderer>().color = Color.red;
            if (other.GetComponent<SpriteRenderer>().flipX == false)
            {
                pRB.velocity = new Vector2(-BumpX,BumpY);
            }
            else if (other.GetComponent<SpriteRenderer>().flipX == true)
            {
                pRB.velocity = new Vector2(BumpX,BumpY);
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Enemi")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }


    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Enemi")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
