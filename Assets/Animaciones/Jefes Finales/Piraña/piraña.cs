using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piraña : MonoBehaviour
{
    // Start is called before the first frame update
    public float visionRadius = 4f;
    public float attackRadius = 1f;
    public float Speed = 2f;

    private GameObject player;

    Vector3 initialPosition;

    private SpriteRenderer sp;
    private Animator anim;
    Rigidbody2D rb2d;


    
    public string mirando;
    private Vector3 dir;
    
    public float tiempo_start=0;//segundos de inicio
    private bool primerAtk = true;
    public int tipoAtaque;
    //private Rigidbody2D rb;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        initialPosition = transform.position;
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        
        //rb = GetComponent<Rigidbody2D>();

        //derechazo = GetComponent<GameObject>();
        //izquierdazo = GetComponent<GameObject>();
        

    }

    void Update()
    {

        if (primerAtk)
        {
            tipoAtaque = 1;
            
            primerAtk = false;
        }
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
            }
            else
            {
                sp.flipX = false;
            }
        }
        else if (mirando == "derecha")
        {
            if (forward.x < 0)
            {
                sp.flipX = true;
            }
            else
            {
                sp.flipX = false;
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
        anim.SetBool("golpe1",false);
        anim.SetBool("golpe2",false);
        anim.SetBool("golpe3",false);
        anim.SetBool("golpe4",false);
        anim.SetBool("golpe5",false);
        if (target != initialPosition && distance < attackRadius)
        {
            anim.SetBool("Golpear",true);
            if (tipoAtaque ==3)
            {
                anim.SetBool("golpe3",true);
            }
            if(tipoAtaque ==2)
            {
                anim.SetBool("golpe2",true);
            }
            if(tipoAtaque ==5)
            {
                anim.SetBool("golpe5",true);
            }
            if(tipoAtaque ==1)
            {
                anim.SetBool("golpe1",true);
            }
            if(tipoAtaque ==4)
            {
                anim.SetBool("golpe4",true);
            }
            
            
        }
        else
        {

            rb2d.MovePosition(transform.position + dir * Speed * Time.deltaTime);
            anim.speed = 1;
            anim.SetBool("Seguir", true);
            anim.SetBool("Golpear", false);
        }

        if (anim.GetBool("Golpear"))
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY |
                               RigidbodyConstraints2D.FreezeRotation;
        }
        else
        {
            rb2d.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        }

        if (sp.sprite.name == ("Invisible_0"))
        {
            //anim.enabled = false;
            //sp.enabled = false;
            
            Destroy(gameObject);
        }


        if (target == initialPosition && distance < 0.01f)
        {
            transform.position = initialPosition;
            anim.SetBool("Seguir", false);
        }

        Debug.DrawLine(transform.position, target, Color.green);
        
       
        tiempo_start += Time.deltaTime;//Función para que la variable tiempo_start vaya contando segundos.
        if (tiempo_start > 7){
            tiempo_start = 0;
            tipoAtaque = Random.Range(1, 6);
            
        }
    }
    
}