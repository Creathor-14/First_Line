﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;
    private Rigidbody2D rd;

    //limites personaje eje y
    public float techo=-0.72f;
    public float suelo=-4.23f;
    
    // limites personaje eje x

    public float derecha = 100.02f;
    public float izquierda = -10.76f;
    
    //sistema de daño
    public float vida = 10f;
    public string tagDelOponente = "Enemy";
    
    
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    { 
//Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("mujer primera linea(limpio)_0")||player.sprite.name==("mujer primera linea(limpio)_1")||player.sprite.name==("mujer primera linea(limpio)_2")||player.sprite.name==("mujer primera linea(limpio)_3") ||player.sprite.name==("mujer primera linea(limpio)_4")
            ||player.sprite.name==("mujer primera linea(limpio)_11")||player.sprite.name==("mujer primera linea(limpio)_12")||player.sprite.name==("mujer primera linea(limpio)_13")||player.sprite.name==("mujer primera linea(limpio)_14")
            ||player.sprite.name==("mujer primera linea(limpio)_53")||player.sprite.name==("mujer primera linea(limpio)_56")||player.sprite.name==("mujer primera linea(limpio)_57")||player.sprite.name==("mujer primera linea(limpio)_58")||player.sprite.name==("mujer primera linea(limpio)_59"))
        {
        }
        else
        {
            mov.x = 0;
            mov.y = 0;
        }
//Detectar limites de movimiento eje y        
        if (techo == player.transform.position.y && player.transform.position.y>0)
        {
            mov.y = 0;
        }
//Detectar limites de movimiento eje x        
        if (izquierda == player.transform.position.x && player.transform.position.x>0)
        {
            mov.x = 0;
        }
//Topes de movimiento en el mapa        
        if (mov.y != 0)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, suelo, techo), transform.position.z);
        }
        if (mov.x != 0)
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha), transform.position.y, transform.position.z);
        }
        
//Genera el movimiento
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
//Animaciones para movimiento
        if (mov.x == 0 && mov.y == 0)
        {
            anim.SetBool("Caminar", false);
        }
        else
        {
            anim.SetBool("Caminar", true);
        }

//Giros del personaje
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = false;
        }
        
//Detectar ataque
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
        }
    }
    
    
//detecta los golpes enemigos y aplica el daño    

    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals(tagDelOponente))
        {
            if (!Input.GetButtonDown(("Fire1")))
            {
                vida -= 4;//deve obtener el valor del daño del que lo golpea (en vez de el 4)
                anim.SetTrigger("Daño");
                if (vida <= 0)
                {
                    anim.SetBool("Muere",true);
                }
/*
 *                Cuando reciva golpes el personaje no podra moverse
 *
 *                 mov.x = 0;
 *                 mov.y = 0;
 */
                
            }
            else//retroceso
            {
                rd.AddForce(Vector2.right*(GetComponentInParent<Transform>().localScale.x*-1)*5,ForceMode2D.Impulse);//Get component depende de cual de los objetos le da el movimiento al jugador(GetComponentInParent) en este caso es Get component normal
            }
        }
    }

    
    
}
//EN Quieto(anim) 2 HAY QUE HACER QUE EL PERSONAJE SE QUEDE QUIETO