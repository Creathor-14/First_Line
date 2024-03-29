﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemy : MonoBehaviour
{
    public float vidaReal;
    public float vida;
    private SpriteRenderer barraVida;
    private Animator anim;
    private BoxCollider2D bc;
    private void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        barraVida = transform.GetChild(2).GetComponent<SpriteRenderer>();
        barraVida.drawMode = SpriteDrawMode.Sliced;
        anim = GetComponent<Animator>();
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (vida > 0)
        {
            float daño;
        //mujer(PL)
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
                anim.Play("daño");
            }
        //matapaco
            if (collision.gameObject.tag == "MP(mordisco)")
            {
                daño = 50f;
                vida -= daño;
                daño /= vidaReal;
                //AGREGAR SANGRADO
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        //karateka
            if (collision.gameObject.tag == "K(golpe)")
            {
                daño = 45;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "K(patada)")
            {
                daño = 53;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "K(patada2)")
            {
                daño = 53;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        //hombre(PL)
            if (collision.gameObject.tag == "HPL(golpe)")
            {
                daño = 44f;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
            if (collision.gameObject.tag == "HPL(patada)")
            {
                daño = 64f;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        //emprendedor
            if (collision.gameObject.tag == "E(golpe)")
            {
                daño = 30;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "E(golpe2)")
            {
                daño = 30;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "E(baston1)")
            {
                daño = 50;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "E(baston2)")
            {
                daño = 100;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        //Sensual Spiderman(o por dios pero mira que sensual)
            if (collision.gameObject.tag == "HPL(golpe1)")
            {
                daño = 30;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "HPL(golpe2)")
            {
                daño = 30;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }if (collision.gameObject.tag == "SM(golpe3)")
            {
                daño = 30;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        //cuando esta en telearaña
            if (collision.gameObject.tag == "0"||collision.gameObject.tag == "1"||collision.gameObject.tag == "2"||collision.gameObject.tag == "3")
            {
                daño = 200;//cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño,0f);
                anim.Play("daño");
            }
        }
        
        else
        {
            barraVida.size = new Vector2(0f,0f);
            bc.enabled = false;
            anim.Play("muerte");
            CantEnemy.cantEnemy += 1;
            
        }
    }
}