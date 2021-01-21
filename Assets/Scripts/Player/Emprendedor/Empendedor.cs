using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
        rd = GetComponent<Rigidbody2D>();
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
            player.sprite.name == ("Emprendedor_11"))
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
        }
        else
        {
            ac.enabled = false; 
        }
        //barrida    
        if(player.sprite.name==("Emprendedor_11"))
        {
            ac1.enabled = true;
        }
        else
        {
            ac1.enabled = false; 
        }
        //barrida2
        if(player.sprite.name==("Emprendedor_37"))
        { 
            ac2.enabled = true;
        }
        else
        { 
            ac2.enabled = false;
        }

        if (player.sprite.name == ("Emprendedor_57"))
        {
            ac3.enabled = true;
        }
        else
        { 
            ac3.enabled = false;
        }
    }
}
