using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Empendedor : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;
    private Rigidbody2D rb;

    public int nivel;
    //limites personaje eje y
    public float techo=-0.72f;
    public float suelo=-3.77f;
    
    // limites personaje eje x
    public float derecha = 100.02f;
    public float izquierda = -10.37f;
    
    //sistema barreras ordas
    private int kills = 0;

    //sistema de daño(2)
    private CircleCollider2D ac;
    private CircleCollider2D ac1;
    private CircleCollider2D ac2;
    private CircleCollider2D ac3;
    //barra vida
    public Image barraVida;
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        ac= transform.GetChild(0).GetComponent<CircleCollider2D>();
        ac.enabled = false;
        ac1= transform.GetChild(1).GetComponent<CircleCollider2D>();
        ac1.enabled = false;
        ac2= transform.GetChild(2).GetComponent<CircleCollider2D>();
        ac2.enabled = false;
        ac3= transform.GetChild(3).GetComponent<CircleCollider2D>();
        ac3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name == ("Emprendedor_7") || player.sprite.name == ("Emprendedor_8") ||
            player.sprite.name == ("Emprendedor_9") || player.sprite.name == ("Emprendedor_10") ||
            player.sprite.name == ("Emprendedor_11")||player.sprite.name == ("Emprendedor_15")||
            player.sprite.name == ("Emprendedor_33")||player.sprite.name == ("Emprendedor_35")||
            player.sprite.name == ("Emprendedor_53")||player.sprite.name == ("Emprendedor_55"))
        {
            mov.x = 0;
            mov.y = 0;
        }
//Animaciones para movimiento
        if (mov.x == 0 && mov.y == 0)
        {
            anim.SetBool("Caminar", false);
        }
        else
        {
            anim.SetBool("Caminar", true);
        }        

        
        
//Detectar limites de movimiento eje y        
            if (techo == player.transform.position.y && player.transform.position.y > 0)
            {
                mov.y = 0;
            }

//Detectar limites de movimiento eje x        
            if (izquierda == player.transform.position.x && player.transform.position.x > 0)
            {
                mov.x = 0;
            }

//Topes de movimiento en el mapa        
            if (mov.y != 0)
            {
                transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, suelo, techo),
                    transform.position.z);
            }
    // topes nivel 1
        if (nivel == 1)
        {
        if (kills == 0)
            {
                derecha = -24.55f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 3)
            {
                derecha = -7.36f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 6)
            {
                derecha = 9.95f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <10)
            {
                derecha = 27.18f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <15)
            {
                derecha = 44.42f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <18)
            {
                derecha = 61.5f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <20)
            {
                derecha = 78.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <23)
            {
                derecha = 95.69f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <26)
            {
                derecha = 112.93f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
        }
            
            
	    // topes nivel 2
        if (nivel == 2)
        {
            izquierda = -21.3f;
            techo = 11.5f;
            suelo = 2.9f;
            
            if (kills == 0)
            {
                derecha = 30.1f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 3)
            {
                derecha = 71.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 6)
            {
                derecha = 112.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <10)
            {
                derecha = 154f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <15)
            {
                derecha = 194.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <18)
            {
                derecha = 236.2f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <20)
            {
                derecha = 278f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <23)
            {
                derecha = 319.2f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <26)
            {
                derecha = 361.1f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
        }
            
	    // topes nivel 3 Y FINAL
            if (nivel == 3)
            {
            izquierda = -21.3f;
            techo = 11.5f;
            suelo = 2.9f;
            
            if (kills == 0)
            {
                derecha = 30.1f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 3)
            {
                derecha = 71.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills < 6)
            {
                derecha = 112.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <10)
            {
                derecha = 154f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <15)
            {
                derecha = 194.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <18)
            {
                derecha = 236.2f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            
            if (kills <20)
            {
                derecha = 278f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <23)
            {
                derecha = 319.2f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            if (kills <26)
            {
                derecha = 361.1f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            }
            

//Genera el movimiento
            transform.position =
                Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
//Animaciones para movimiento
        if (Input.GetAxisRaw("Horizontal") < 0)//izquierda
        {
            player.flipX = true;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-3f,1f,0);//golpes
            if(mov!= Vector3.zero) ac1.offset= new Vector3(-3f,1f,0);//barrida
            if(mov!= Vector3.zero) ac2.offset= new Vector3(-3f,1f,0);//patada2
            if(mov!= Vector3.zero) ac3.offset= new Vector3(-3,1f,0);//patada2
        }
        else if (Input.GetAxisRaw("Horizontal") > 0) //derecha
        {
            player.flipX = false;
            if (mov != Vector3.zero) ac.offset = new Vector3(-0.3f, 1f, 0); //golpes
            if (mov != Vector3.zero)ac1.offset = new Vector3(-0.3f, 1f, 0); //patada
            if (mov != Vector3.zero)ac2.offset = new Vector3(-0.3f, 1f, 0); //patada2
            if (mov != Vector3.zero)ac3.offset = new Vector3(-0.3f, 1f,0);//patada2
        }

//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            
        }
        
//Cambio de arma
        if (Input.GetButtonDown("Fire2"))
        {
            anim.SetTrigger(("Arma"));
            
        }
        /*
        if (player.sprite.name == ("Emprendedor_15"))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                cont += 1;
            }
        }
        */
        if (barraVida.fillAmount > 0.5f)
        {
            anim.SetBool("TipoArma", false);
        }
        else
        {
            anim.SetBool("TipoArma", true);
        }
//Activar o desactivar colaider    
        //golpes
        if (player.sprite.name==("Emprendedor_8"))
        {
            ac.enabled = true;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            ac.enabled = false; 
        }
        //barrida    
        if(player.sprite.name==("Emprendedor_11"))
        {
            ac1.enabled = true;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            ac1.enabled = false; 
        }
        //barrida2
        if(player.sprite.name==("Emprendedor_37"))
        { 
            ac2.enabled = true;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        { 
            ac2.enabled = false;
        }

        if (player.sprite.name == ("Emprendedor_57"))
        {
            ac3.enabled = true;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        { 
            ac3.enabled = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "tope")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            rb.constraints =RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
