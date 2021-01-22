using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HombrMove : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;
    private Rigidbody2D rb;
    
    //sistema barreras ordas
    private int kills = 0;
    
    //limites personaje eje y
    public float techo=-0.72f;
    public float suelo=-3.77f;
    
    // limites personaje eje x
    public float derecha = 100.02f;
    public float izquierda = -10.37f;
    
    //sistema de daño(2)
    private CircleCollider2D ac;
    private CircleCollider2D ac1;
    public int nivel;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
        ac= transform.GetChild(0).GetComponent<CircleCollider2D>();
        ac.enabled = false;
        ac1= transform.GetChild(1).GetComponent<CircleCollider2D>();
        ac1.enabled = false;
    }

void FixedUpdate()
    { 
        
//Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("hombre primera linea_19")||player.sprite.name==("hombre primera linea_20")||player.sprite.name==("hombre primera linea_21"))
        {
            mov.x = 0;
            mov.y = 0;
            
        }
        else
        {
            
            
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
        if (mov.x != 0 || mov.y != 0)
        {
            anim.SetBool("Caminar", true);
        }
        else
        {
            anim.SetBool("Caminar", false);
        }
        
//Giros del personaje + cambiar posicion colaiders
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = false;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-0.3f,0.681481f,0);//golpe
            if(mov!= Vector3.zero) ac1.offset= new Vector3(-0.3f,0.681481f,0);//barrida
            //if(mov!= Vector3.zero) ac2.offset= new Vector3(-1.5f,3f,0);//barrida2
        }
        
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = true;
            if(mov!= Vector3.zero) ac.offset= new Vector3(0.6f,0.681481f,0);//golpe
            if(mov!= Vector3.zero) ac1.offset= new Vector3(0.6261416f,0.681481f,0);//patada
            //if(mov!= Vector3.zero) ac2.offset= new Vector3(1.5f,3f,0);//barrida2
        }
        
//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            
        }
//Activar o desactivar colaider    
    //golpes
        if (player.sprite.name==("hombre primera linea_20"))
        {
            ac.enabled = true;
        }
        else
        {
            ac.enabled = false; 
        }
    //barrida 
    
        if(player.sprite.name==("hombre primera linea_16"))
        {
            ac1.enabled = true;
        }
        else
        {
            ac1.enabled = false; 
        }
        
        if (Input.GetButtonDown("Fire2"))
        {
            anim.SetTrigger("dempsey roll");
        }
    //dempsey roll
        if (player.sprite.name == ("hombre primera linea_22")||player.sprite.name==("hombre primera linea_23")||player.sprite.name==("hombre primera linea_24")||player.sprite.name==("hombre primera linea_25"))
        {
           rb.bodyType = RigidbodyType2D.Kinematic;
        }
        else
        {
           rb.bodyType= RigidbodyType2D.Dynamic;
        }

        
        /*
            //barrida2
            if(player.sprite.name==("mujer primera linea(limpio)_70"))
            { 
                ac2.enabled = true;
            }
            else
            { 
                ac2.enabled = false;
            }
        */
        //https://www.youtube.com/watch?v=0LgCaEMCoz8
        //min 12:33
    }
}
