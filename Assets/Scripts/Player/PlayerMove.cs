using System;
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
    public float suelo=-3.77f;
    
    // limites personaje eje x
    public float derecha = 100.02f;
    public float izquierda = -10.37f;
    
    //sistema barreras ordas
    private int kills = 0;
    
    //sistema de daño(1)
    public float vida = 10f;
    public string tagDelOponente = "Enemy";
    
    //sistema de daño(2)
    private CircleCollider2D ac;
    private CircleCollider2D ac1;
    private CircleCollider2D ac2;
    
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
        ac= transform.GetChild(0).GetComponent<CircleCollider2D>();
        ac.enabled = false;
        ac1= transform.GetChild(1).GetComponent<CircleCollider2D>();
        ac1.enabled = false;
        ac2= transform.GetChild(2).GetComponent<CircleCollider2D>();
        ac2.enabled = false;
        
    }

    void FixedUpdate()
    { 
//Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("mujer primera linea(limpio)_0")||player.sprite.name==("mujer primera linea(limpio)_1")||player.sprite.name==("mujer primera linea(limpio)_2")||player.sprite.name==("mujer primera linea(limpio)_3") ||player.sprite.name==("mujer primera linea(limpio)_4")
            ||player.sprite.name==("mujer primera linea(limpio)_11")||player.sprite.name==("mujer primera linea(limpio)_12")||player.sprite.name==("mujer primera linea(limpio)_13")||player.sprite.name==("mujer primera linea(limpio)_14")
            ||player.sprite.name==("mujer primera linea(limpio)_53")||player.sprite.name==("mujer primera linea(limpio)_56")||player.sprite.name==("mujer primera linea(limpio)_57")||player.sprite.name==("mujer primera linea(limpio)_58"))
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

        if (kills == 0)
        {
            derecha = 5.72f;
            if (mov.x != 0)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha), transform.position.y, transform.position.z);
            }
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

//Giros del personaje + cambiar posicion colaiders
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-2.5f,1f,0);//golpes
            if(mov!= Vector3.zero) ac1.offset= new Vector3(-3f,-0.4f,0);//barrida
            if(mov!= Vector3.zero) ac2.offset= new Vector3(-1.5f,3f,0);//barrida2
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = false;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-0.3f,1f,0);//golpes
            if(mov!= Vector3.zero) ac1.offset= new Vector3(3f,-0.4f,0);//barrida
            if(mov!= Vector3.zero) ac2.offset= new Vector3(1.5f,3f,0);//barrida2
        }
        
//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            
        }
//Activar o desactivar colaider    
    //golpes
        if (player.sprite.name==("mujer primera linea(limpio)_27")||player.sprite.name==("mujer primera linea(limpio)_28")||player.sprite.name==("mujer primera linea(limpio)_33")||player.sprite.name==("mujer primera linea(limpio)_40"))
        {
            ac.enabled = true;
        }
        else
        {
            //ac.enabled = false; ver q wa
        }
    //barrida    
        if(player.sprite.name==("mujer primera linea(limpio)_59"))
        {
            ac1.enabled = true;
        }
        else
        {
            //ac1.enabled = false; ver que wa
        }
    //barrida2
        if(player.sprite.name==("mujer primera linea(limpio)_70"))
        {
         ac2.enabled = true;
     }
        else
        {
          //ac2.enabled = false; ver que wa
        }
        //https://www.youtube.com/watch?v=0LgCaEMCoz8
        //min 12:33
    }
}
//EN Quieto(anim) 2 HAY QUE HACER QUE EL PERSONAJE SE QUEDE QUIETO