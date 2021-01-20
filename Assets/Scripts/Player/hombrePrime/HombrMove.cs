using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HombrMove : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;
    private Rigidbody2D rd;
    
    //sistema barreras ordas
    private int kills = 0;
    
    //sistema de daño(2)
    private CircleCollider2D ac;
    private CircleCollider2D ac1;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rd = GetComponent<Rigidbody2D>();
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
//Genera el movimiento
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
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
            if(mov!= Vector3.zero) ac.offset= new Vector3(-0.3f,0.681481f,0);//golpes
            //if(mov!= Vector3.zero) ac1.offset= new Vector3(-3f,-0.4f,0);//barrida
            //if(mov!= Vector3.zero) ac2.offset= new Vector3(-1.5f,3f,0);//barrida2
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = true;
            if(mov!= Vector3.zero) ac.offset= new Vector3(0.6261416f,0.681481f,0);//golpes
            //if(mov!= Vector3.zero) ac1.offset= new Vector3(3f,-0.4f,0);//barrida
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
