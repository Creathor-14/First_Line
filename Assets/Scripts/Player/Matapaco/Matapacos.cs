using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matapacos : MonoBehaviour
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
    private int kills = 0;
    
    //sistema de daño(2)
    private CircleCollider2D ac;
    public int nivel;
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
        ac= transform.GetChild(0).GetComponent<CircleCollider2D>();
        ac.enabled = false;
    }

    void FixedUpdate()
    {
//Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name == ("mujer primera linea(limpio)_0") ||
            player.sprite.name == ("mujer primera linea(limpio)_1") ||
            player.sprite.name == ("mujer primera linea(limpio)_2") ||
            player.sprite.name == ("mujer primera linea(limpio)_3") ||
            player.sprite.name == ("mujer primera linea(limpio)_4")
            || player.sprite.name == ("mujer primera linea(limpio)_11") ||
            player.sprite.name == ("mujer primera linea(limpio)_12") ||
            player.sprite.name == ("mujer primera linea(limpio)_13") ||
            player.sprite.name == ("mujer primera linea(limpio)_14")
            || player.sprite.name == ("mujer primera linea(limpio)_53") ||
            player.sprite.name == ("mujer primera linea(limpio)_56") ||
            player.sprite.name == ("mujer primera linea(limpio)_57") ||
            player.sprite.name == ("mujer primera linea(limpio)_58") ||
            player.sprite.name == ("mujer primera linea(limpio)_59"))
        { }
        /*
        else
        {
            mov.x = 0;
            mov.y = 0;
        }
        */
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
                izquierda = 0f;
            {

                derecha = 6.07f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 3)
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

            if (kills < 3)
            {
                derecha = 102.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 6)
            {
                derecha = 145.5f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 10)
            {
                derecha = 184.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 15)
            {
                derecha = 225f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 18)
            {
                derecha = 266.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 20)
            {
                derecha = 308.7f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 23)
            {
                derecha = 349.8f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 26)
            {
                derecha = 391.6f;
                if (mov.x != 0)
                {
                    transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                        transform.position.y, transform.position.z);
                }
            }

            if (kills < 30)
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
            transform.position =
                Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);

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
            if(mov!= Vector3.zero) ac.offset= new Vector3(-1.7f,0f,0);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = false;
            if(mov!= Vector3.zero) ac.offset= new Vector3(0f,0f,0);
        }
        

//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
        }
//Activar o desactivar colaider        
        if (player.sprite.name==("matapaco (2)_9")||player.sprite.name==("matapaco (2)_10")||player.sprite.name==("matapaco (2)_11"))
        {
            ac.enabled = true;
        }
        else
        {
            ac.enabled = false;
        }
    }
}
