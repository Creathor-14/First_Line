using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemy : MonoBehaviour
{
    public float vidaReal;
    public float vida;
    private SpriteRenderer barraVida;
    private Animator anim;
    private int cont = 0;
    private void Start()
    {
        barraVida = transform.GetChild(2).GetComponent<SpriteRenderer>();
        barraVida.drawMode = SpriteDrawMode.Sliced;
        anim = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (vida > 0)
        {
            float daño;
            //primera linea
            if (collision.gameObject.tag == "PL(golpe-normal)")
            {
                daño = 44f;
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
                
            }
            if (collision.gameObject.tag == "PL(golpe-especial)")
            {
                daño = 64f;
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
            }
            //matapaco
            if (collision.gameObject.tag == "MP(mordisco)")
            {
                daño = 66f;
                vida -= daño;
                daño /= vidaReal;
                //AGREGAR SANGRADO
                barraVida.size -= new Vector2(daño,0f);
            }
            //karateka
            
            //hombre
            
            //empresario
            
            //Sensual Spiderman(o por dios pero mira que sensual)
            
        }
        else
        {
            barraVida.size = new Vector2(0f,0f);
            anim.Play("muerte");
            
        }
        
    }
}
