using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public static PlayerMove Player;
    public float speed= 4f;
    private Rigidbody2D rb;
    private SpriteRenderer player;
    private Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }


    
    void FixedUpdate()
    {
        //Permite el movimiento del personaje
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
        //Animaciones para movimiento
        if (mov.x==0 && mov.y==0)
        {
            anim.SetBool("Caminar",false);
        }
        else
        {
            anim.SetBool("Caminar",true);
        }
        //Giros del personaje
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") >0)
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