using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{
//Atributos del enemigo    
    public float visionRadius = 4f;
    public float attackRadius =1f;
    public float Speed = 1f;
//Guarda el jugador
    private GameObject player;
//Posicion inicial
    Vector3 initialPosition;
//Llamamos a las cualidades del objeto
    private Animator anim;
    Rigidbody2D rb2d;
    
    void Start()
    {
//obtenemos al jugador gracias a su tag
        player = GameObject.FindGameObjectWithTag("Player");
        
//Guardamos nuestra posicion inicial        
        initialPosition = transform.position;
        
//nombramos a las cualidades del objeto        
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
//Posicion inicial(por eso vuelve)        
        Vector3 target = initialPosition;
        
//Vemos la distancia entre el jugador y el enemigo         
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, visionRadius, 
            1 << LayerMask.NameToLayer("Default"));
        
//Muestra la linea del rycast            
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);
        
//Si el ve al jugador lo toma como target
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player")
            {
                target = player.transform.position;
                print("sdñfhawudhsfñasd");
            }
        }
        
//Calcula la distancia y la direccion al jugador(normalized = 0,-1,1)
        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;
        
//En este caso lo atacamos      
        if (target != initialPosition && distance < attackRadius)
        { 
        //aca es donde ataca    
            anim.Play("Golpes",-1,0);
        }
//En este caso lo seguimos        
        else
        {
            rb2d.MovePosition(transform.position+dir * Speed * Time.deltaTime);
        //Animacion de movimiento
            anim.speed = 1;
            anim.SetBool("Seguir",true);
        }

        if (target == initialPosition && distance < 0.01f)
        {
            transform.position = initialPosition;
            anim.SetBool("Seguir", false);
        }
        Debug.DrawLine(transform.position , target, Color.green);
    }

    
}
