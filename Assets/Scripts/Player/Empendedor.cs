using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Empendedor : MonoBehaviour
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
    
    //condicion para sacar el tipo de arma
    private int cont=0;
    
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name == ("Emprendedor_7") || player.sprite.name == ("Emprendedor_8") ||
            player.sprite.name == ("Emprendedor_9") || player.sprite.name == ("Emprendedor_10") ||
            player.sprite.name == ("Emprendedor_11"))
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
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = false;
        }
        
//Atacar
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            
        }
//Cambio de arma
        if (player.sprite.name == ("Emprendedor_15"))
        {
            if (Input.GetButtonDown("Fire1"))
            {
                cont += 1;
            }
        }
        if (cont < 10)
        {
            anim.SetBool("TipoArma", false);
        }
        else
        {
            anim.SetBool("TipoArma", true);
        }
    }
}
