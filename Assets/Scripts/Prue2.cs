using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prue2 : MonoBehaviour
{
    // Start is called before the first frame update
    public float visionRadius;
    public float attackRadius;
    public float Speed;

    private GameObject player;

    Vector3 initialPosition;

    private Animator anim;
    Rigidbody2D rb2d;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 target = initialPosition;
        
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, visionRadius, 
            1 << LayerMask.NameToLayer("Default"));
            
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);

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
            anim.SetFloat("movX",dir.x);
            anim.SetFloat("movY",dir.y);
            anim.Play("CentinelaWalk",-1,0);
        }
        else
        {
            rb2d.MovePosition(transform.position+dir * Speed * Time.deltaTime);

            anim.speed = 1;
            anim.SetFloat("movX",dir.x);
            anim.SetFloat("movY",dir.y);
            anim.SetBool("walking",true);
        }

        if (target == initialPosition && distance < 0.01f)
        {
            transform.position = initialPosition;
            anim.SetBool("walking", false);
        }
        Debug.DrawLine(transform.position , target, Color.green);

    }
    
}
