using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(Animator))]

public class PlayerMove : MonoBehaviour
{
    private SpriteRenderer sprite;
    public float speed= 4f;

    private void Awake()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }


    
    void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * speed);
        
        
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            sprite.flipX = true;
        }
        else if(Input.GetAxisRaw("Horizontal") >0)
        {
            sprite.flipX = false;
        }    
        
    }
}
