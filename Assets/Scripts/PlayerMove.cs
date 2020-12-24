using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 4f;
    private SpriteRenderer player;
    private Animator anim;

    //limites personaje eje y
    public float techo=-0.72f;
    public float suelo=-4.23f;
    
    

    void Start()
    {
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    { 
//Movimiento------------------------------------------------------------------------------------------------------------
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
//segun animaciones
        if (player.sprite.name==("mujer primera linea(limpio)_0")||player.sprite.name==("mujer primera linea(limpio)_1")||player.sprite.name==("mujer primera linea(limpio)_2")||player.sprite.name==("mujer primera linea(limpio)_3") ||player.sprite.name==("mujer primera linea(limpio)_4")
            ||player.sprite.name==("mujer primera linea(limpio)_11")||player.sprite.name==("mujer primera linea(limpio)_12")||player.sprite.name==("mujer primera linea(limpio)_13")||player.sprite.name==("mujer primera linea(limpio)_14")
            ||player.sprite.name==("mujer primera linea(limpio)_53")||player.sprite.name==("mujer primera linea(limpio)_56")||player.sprite.name==("mujer primera linea(limpio)_57")||player.sprite.name==("mujer primera linea(limpio)_58")||player.sprite.name==("mujer primera linea(limpio)_59"))
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
        if (mov.y != 0)
        {
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, suelo, techo), transform.position.z);
        }
        
        
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

        //Giros del personaje
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.flipX = false;
        }
        
        //Detectar ataque
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
        }
    }
}
//EN Quieto(anim) 2 HAY QUE HACER QUE EL PERSONAJE SE QUEDE QUIETO