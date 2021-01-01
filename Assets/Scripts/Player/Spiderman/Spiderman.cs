using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vector2 = System.Numerics.Vector2;

public class Spiderman : MonoBehaviour
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

    //Telearañas
    
    
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        //Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("SpiderMan_0")||player.sprite.name==("SpiderMan_1")||player.sprite.name==("SpiderMan_2") //idle
            ||player.sprite.name==("SpiderMan_4") ||player.sprite.name==("SpiderMan_4")
            ||player.sprite.name==("SpiderMan_5")||player.sprite.name==("SpiderMan_6")||player.sprite.name==("SpiderMan_7")||player.sprite.name==("SpiderMan_8")
            ||player.sprite.name==("SpiderMan_9")||player.sprite.name==("SpiderMan_10")||player.sprite.name==("SpiderMan_11"))
        {
        }
        else
        {
            mov.x = 0;
            mov.y = 0;
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

        if (kills == 0)
        {
            derecha = 5.72f;
            if (mov.x != 0)
            {
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, izquierda, derecha),
                    transform.position.y, transform.position.z);
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
    //saltito

            if (Input.GetButtonDown("Fire2"))
            {
                anim.SetTrigger("Salto");
            }
        }

//Giros del personaje + cambiar posicion colaiders
        if (player.sprite.name == ("Invisible_0"))
        {
            
        }
        else
        {
            if (Input.GetAxisRaw("Horizontal") < 0)
            {
                player.flipX = true;
            }
            else if (Input.GetAxisRaw("Horizontal") > 0)
            {
                player.flipX = false;
                ;
            }
        }

        
//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));

        }
 

    }
}
