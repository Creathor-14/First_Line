using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMove : MonoBehaviour
{
    public float visionRadius = 4f;
    public float attackRadius = 1f;
    public float Speed = 2f;
    private GameObject player;

    Vector3 initialPosition;

    private SpriteRenderer sp;
    //private Animator anim;
    Rigidbody2D rb2d;
    
    public string mirando;
    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
       // anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 target = initialPosition;
        
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, visionRadius, 
            1 << LayerMask.NameToLayer("Default"));
            
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);
        
        //hitBox de golpes segun a donde parte mirando el sprite
        if (mirando == "izquierda")
        {
            if (forward.x > 0)
            {
                sp.flipX = true;
                //bc.enabled = false;
                //if (sp.sprite.name == (animGolpe))
                //{
                    //bc1.enabled = true;
                //}
               // else
                //{
                   // bc1.enabled = false;
               // }
            }
            else
            {
                sp.flipX = false;
               // bc1.enabled = false;
                //if (sp.sprite.name == (animGolpe))
                //{
                   // bc.enabled = true;
                //}
                //else
                //{
                   // bc.enabled = false;
                //}
            }//
        }
        else if (mirando == "derecha")
        {
            if (forward.x < 0)
            {
                sp.flipX = true;
                //bc1.enabled = false;
                //if (sp.sprite.name == (animGolpe))
               // { 
                    //bc.enabled = true;
               // }
               // else
              //  {
                    //bc.enabled = false;
               // }
            }
            else
            {
                sp.flipX = false;
                //bc.enabled = false;
                //if (sp.sprite.name == (animGolpe))
               // {
                    //bc1.enabled = true;
               // }
               // else
               // {
                    //bc1.enabled = false;
               // }
                
                
            }
        }
        else
        {
            print("NO ELIGIO IZQUIERDA O DERECHA");
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
            //anim.SetBool("Golpear",true);
            //anim.Play("golpes",-1,2);
        }
        else
        {
           
            rb2d.MovePosition(transform.position+dir * Speed * Time.deltaTime);
            //anim.speed = 1;
            //anim.SetBool("Seguir",true);
            //anim.SetBool("Golpear",false);
        }

        //if (anim.GetBool("Golpear"))
        //{
         //   rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        //}
        //else
        //{
        //    rb2d.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        //}

        if (sp.sprite.name == ("Invisible_0"))
        {
            //anim.enabled = false;
            //sp.enabled = false;
            
            Destroy(gameObject);
        }
        
        
        if (target == initialPosition && distance < 0.01f)
        {
            transform.position = initialPosition;
            //anim.SetBool("Seguir", false);
        }
        Debug.DrawLine(transform.position , target, Color.green);
        
    }
    
}