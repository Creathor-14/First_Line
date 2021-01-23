using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karateca : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;
    private Rigidbody2D rd;
    
    //limites personaje eje y
    public float techo=-0.72f;
    public float suelo=-3.77f;
    
    // limites personaje eje x
    private float derecha = 0f;
    private float izquierda = 0f;
    
    //sistema barreras ordas
    private int kills = CantEnemy.cantEnemy;
    public int nivel;
    
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

    // Update is called once per frame
    void FixedUpdate()
    {//aaaaaaa
        //Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("karateca limpio_0")||player.sprite.name==("karateca limpio_1")||player.sprite.name==("karateca limpio_2")||player.sprite.name==("karateca limpio_3") ||player.sprite.name==("karateca limpio_4")
            ||player.sprite.name==("karateca limpio_5")||player.sprite.name==("karateca limpio_6"))
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
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, suelo, techo),
                transform.position.z);
        }
        // topes nivel 1 y RUN ( 4 )
        if (nivel == 1)
        {
            izquierda = -8.45f;
            if (CantEnemy.cantEnemy == 0)
            {
                derecha = 6.07f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (CantEnemy.cantEnemy < 3)
            {
                derecha = 23.14f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 6)
            {
                derecha = 40.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 10)
            {
                derecha = 57.79f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 15)
            {
                derecha = 74.98f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 18)
            {
                derecha = 92.02f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 20)
            {
                derecha = 109.1f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            else if (kills < 23)
            {
                derecha = 126.36f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            else if (kills < 26)
            {
                derecha = 143.52f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
            else if (kills < 30)
            {
                derecha = 160.7f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
        }


        // topes nivel 2, 3 y 5
        if (nivel == 2)
        {
            izquierda = 9.2f;
            techo = -2.07f;
            suelo = -9.51f;

            if (kills == 0)
            {
                derecha = 60.7f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 3)
            {
                derecha = 102.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 6)
            {
                derecha = 145.5f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 10)
            {
                derecha = 184.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 15)
            {
                derecha = 225f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 18)
            {
                derecha = 266.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 20)
            {
                derecha = 308.7f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 23)
            {
                derecha = 349.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 26)
            {
                derecha = 391.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            else if (kills < 30)
            {
                derecha = 433.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }
        }

        // topes nivel run
        if (nivel == 4)
        {
            izquierda = 9.2f;
            techo = -2.07f;
            suelo = -9.51f;

            if (kills == 0)
            {
                derecha = 160.7f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
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
        if (Input.GetAxisRaw("Horizontal") < 0)//izquierda
        {
            player.flipX = true;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-1.5f,1f,0);//golpes
            if(mov!= Vector3.zero) ac1.offset= new Vector3(-1f,1f,0);//barrida
            if(mov!= Vector3.zero) ac2.offset= new Vector3(-0.4406126f,1f,0);//patada2
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)//derecha
        {
            player.flipX = false;
            if(mov!= Vector3.zero) ac.offset= new Vector3(-0.3f,1f,0);//golpes
            if(mov!= Vector3.zero) ac1.offset= new Vector3(0f,1f,0);//patada
            if(mov!= Vector3.zero) ac2.offset= new Vector3(-0.4406126f,1f,0);//patada2
        } 
        
//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            
        }
//Activar o desactivar colaider    
        //golpes
        if (player.sprite.name==("karateca limpio_12"))
        {
            ac.enabled = true;
        }
        else
        {
            ac.enabled = false; 
        }
        //barrida    
        if(player.sprite.name==("karateca limpio_15"))
        {
            ac1.enabled = true;
        }
        else
        {
            ac1.enabled = false; 
        }
        //barrida2
        if(player.sprite.name==("karateca limpio_20"))
        { 
            ac2.enabled = true;
        }
        else
        { 
            ac2.enabled = false;
        }

    }
}
