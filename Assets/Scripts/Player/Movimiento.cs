using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float velocidad = 4f;
    public SpriteRenderer jugador;
    public Animator animaciones;
    
    void Start()
    {
        jugador = GetComponent<SpriteRenderer>();
        animaciones = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movimiento = caminar();
        animaciones.SetBool("Moverse",esta_moviendose(movimiento));
        girar(movimiento);
        
        if(jugador == hombre primera linea){//las animaciones del hombre al moverse estan invertidas
            jugador.flipX = girar(!movimiento);
        }
        else{
            jugador.flipX = girar(movimiento);
        }
        
    }

    private Vector3 caminar(){
        Vector3 movimiento = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        transform.position =
                Vector3.MoveTowards(transform.position, transform.position + movimiento, Time.deltaTime * velocidad);
        return movimiento;
    }
    private bool esta_moviendose(Vector3 movimiento){
        if (movimiento.x == 0 && movimiento.y == 0)
        {
            return false;
        }
        return true;
    }
    private bool girar(Vector3 movimiento){
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //if(movimiento!= Vector3.zero) ac.offset= new Vector3(-1.7f,0f,0);
            return true;
        }
        //if(movimiento!= Vector3.zero) ac.offset= new Vector3(0f,0f,0);
        return false;

    }
}
