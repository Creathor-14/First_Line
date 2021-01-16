using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMove : MonoBehaviour
{
    public Transform player;

    private Rigidbody2D rb;

    private SpriteRenderer sp;

    public string mirando = "hacia donde parte mirando el script?(derecha o izquierda)";
    public float velocidad = 7f;
    private Vector3 movimiento;

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direccion = player.position - transform.position;//ve la posicion del jugador en tiempo real
        //Debug.Log(direction);muestra por pantalla la posicion del personaje
        if (direccion.x < 0)//Segun donde esta el player
        {
            //arregla la posicion que mira el enemigo en tiempo real
            if(mirando=="izquierda")
            {
                sp.flipX=false;
            }
            if (mirando == "derecha")
            {
                sp.flipX=true;
            }
        }
        else if (direccion.x > 0)//Segun donde esta el player
        {
            //arregla la posicion que mira el enemigo en tiempo real
            if (mirando == "izquierda")
            {
                sp.flipX=true;
            }
            if(mirando=="derecha")
            {
                sp.flipX=false;
            }
          
        }
        direccion.Normalize();
        movimiento = direccion;

        if (anim.GetBool("seguir"))
        {
            print("dslfhadñsfhñadsbfkjdbsafkbds");
            
        }
    }

    private void FixedUpdate()
    {
        moverEnemigo(movimiento);//llama a la funcion que mueve al enemigo
        anim.SetBool("Seguir",true);
        
    }

    void moverEnemigo(Vector3 movimiento)//mueve al enemigo
    {
        rb.MovePosition(transform.position + (movimiento* velocidad * Time.deltaTime));
        
    }
}
