using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prue2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float visionRadius = 4f;
    public float attackRadius =1f;
    public float Speed = 2f;

    private GameObject player;

    Vector3 initialPosition;

    private SpriteRenderer sp;
    private Animator anim;
    Rigidbody2D rb2d;
    private BoxCollider2D bc;
    
    public float DerechaOffSetX;
    public float DerechaOffSetY;
    public float DerechaSizeX;
    public float DerechaSizeY;
    public float IzquierdaOffSetX;
    public float IzquierdaOffSetY;
    public float IzquierdaSizeX;
    public float IzquierdaSizeY;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        bc = transform.GetChild(0).GetComponent<BoxCollider2D>();
        bc.enabled = false;
    }
    void Update()
    {
        Vector3 target = initialPosition;
        
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, visionRadius, 
            1 << LayerMask.NameToLayer("Default"));
            
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);
        if (forward.x > 0)
        {
            sp.flipX = true;
            bc.offset= new Vector2(DerechaOffSetX,DerechaOffSetY);
            bc.size=new Vector2(DerechaSizeX,DerechaSizeY);
            
        }
        else
        {
            sp.flipX = false;
            bc.offset= new Vector2(IzquierdaOffSetX,IzquierdaOffSetY);
            bc.size=new Vector2(IzquierdaSizeX,IzquierdaSizeY);
            
        }
        if (hit.collider != null)
        {
            if (hit.collider.tag == "Player")
            {
                target = player.transform.position;
            }
        }
       

        float distance = Vector3.Distance(target, transform.position);
        Vector3 dir = (target - transform.position).normalized;

        if (target != initialPosition && distance < attackRadius)
        {
            anim.SetBool("Golpear",true);
            //anim.Play("golpes",-1,2);
        }
        else
        {
            rb2d.MovePosition(transform.position+dir * Speed * Time.deltaTime);
            anim.speed = 1;
            anim.SetBool("Seguir",true);
            anim.SetBool("Golpear",false);
        }

        if (target == initialPosition && distance < 0.01f)
        {
            transform.position = initialPosition;
            anim.SetBool("Seguir", false);
        }
        Debug.DrawLine(transform.position , target, Color.green);
        if (sp.sprite.name == ("centinela con cuchillo PNG_15"))
        {
            bc.enabled = true;
        }
        else
        {
            bc.enabled = false;
        }
    }
    
}
