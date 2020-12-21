using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed= 4f;

    private Rigidbody2D rb;

    private SpriteRenderer player;

    private Animator caminar;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<SpriteRenderer>();
        caminar = GetComponent<Animator>();
    }


    
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
        if (mov.x==0 && mov.y==0)
        {
            caminar.SetBool("Caminar",false);
        }
        else
        {
            caminar.SetBool("Caminar",true);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") >0)
        {
            player.flipX = false;
        }    
        
    }
}
