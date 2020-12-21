using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
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


    
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        //animaciones para movimiento
        if (mov.x==0 && mov.y==0)
        {
            anim.SetBool("Caminar",false);
        }
        else
        {
            anim.SetBool("Caminar",true);
        }
        //giros del personaje
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") >0)
        {
            player.flipX = false;
        }    
        //detectar ataque
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetTrigger(("Ataque"));
            mov.x = 0;
            mov.y = 0;
        }
    }
}
