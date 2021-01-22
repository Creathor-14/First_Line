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

    Vector3 initialPosition; // Posicion Inicial

    private SpriteRenderer sp;
    private Animator anim;
    Rigidbody2D rb2d;
    
    private BoxCollider2D bc;//Hijo1
    private BoxCollider2D bc1;//Hijo2
    public string animGolpe;
    public string mirando; //Detecta la posicion con la que empieza el enemigo para poder llevar acabo la animación
    private Vector3 dir; // Dirección

    //private Rigidbody2D rb;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");// Con el tag encuentra al jugador
        initialPosition = transform.position; // Cambia su posicion    
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
        //rb = GetComponent<Rigidbody2D>();
        
        bc = transform.GetChild(0).GetComponent<BoxCollider2D>();// Creamos 2 hijos
        bc.enabled = false;
        bc1 = transform.GetChild(1).GetComponent<BoxCollider2D>();// Que empiezen en falso para que luego detecten el ataque
        bc1.enabled = false;
        
    }
    void Update()
    {
        Vector3 target = initialPosition;
        
        RaycastHit2D hit = Physics2D.Raycast(
            transform.position, player.transform.position - transform.position, visionRadius, 
            1 << LayerMask.NameToLayer("Default"));//Calculamos la distancia con un raycast para que luego llegue a esa posicion
            
        Vector3 forward = transform.TransformDirection(player.transform.position - transform.position);
        Debug.DrawRay(transform.position, forward, Color.red);//Marcamos una linea roja para que detecte al enemigo y su posicion 
        
        //hitBox de golpes segun a donde parte mirando el sprite
        if (mirando == "izquierda") 
        {
            if (forward.x > 0)//Empezamos con el eje x positivo
            {
                sp.flipX = true;
                bc.enabled = false;// denotamos a su hijo en falso y de acuerdo a eso el otro hijo reconoce la animacion
                if (sp.sprite.name == (animGolpe))//Reconoce la animacion para el eje x positivo
                {
                    bc1.enabled = true;// La reconoce como verdadera para el lado donde esté el enemigo
                }
                else
                {
                    bc1.enabled = false;//La reconoce como falsa en negativa por que no lo esta mirando a ese lado
                }
            }
            else
            {
                sp.flipX = false;//Si empieza con la posicion del eje x pero en falso
                bc1.enabled = false;// y el hijo para la parte negativa
                if (sp.sprite.name == (animGolpe)) // Reoconoce la animacion hacia el otro lado
                {
                    bc.enabled = true;//Sera verdadera si esta para ese lado
                }
                else
                {
                    bc.enabled = false;
                }
            }
        } 
        else if (mirando == "derecha")//En este caso si el personaje empieza mirando hacia la derecha
        {
            if (forward.x < 0)// Si es que la posicion es menor que 0
            {
                sp.flipX = true;//Reconocemos el lado X positivo
                bc1.enabled = false; // y el hijo en falso
                if (sp.sprite.name == (animGolpe))//Ahora reconocemos la animacion para el x positivo pero sin el segundo hijo
                {
                    bc.enabled = true;
                }
                else
                {
                    bc.enabled = false;
                }
            }
            else
            {
                sp.flipX = false;//Con el x negativo 
                bc.enabled = false;//El primer hijo en falso
                if (sp.sprite.name == (animGolpe))
                {
                    bc1.enabled = true;
                }
                else
                {
                    bc1.enabled = false;
                }
            }
        }
        else
        {
            print("NO ELIGIO IZQUIERDA O DERECHA");//Imprimimos cen caso que no este para ningun lado salga esto
        }
        
        if (hit.collider != null)//Reconocimos los collider
        {
            if (hit.collider.tag == "Player")//Para llegar hacia donde el player
            {
                target = player.transform.position;//Logre cambiar su posicion
            }
        }
       

        float distance = Vector3.Distance(target, transform.position);//Calculamos su posicion de distancis
        Vector3 dir = (target - transform.position).normalized;// Y segun cuan lejos estea el radio de vision lo reconocera

        if (target != initialPosition && distance < attackRadius)//Cuando la distancia sea minima osea estea al lado 
        {
            anim.SetBool("Golpear",true);//Se reconocera la animacion de Golpe
            //anim.Play("golpes",-1,2);
        }
        else
        {
            rb2d.MovePosition(transform.position+dir * Speed * Time.deltaTime);//Calculamos el movimiento segun su direccion y velocidad
            anim.speed = 1;
            anim.SetBool("Seguir",true);//Y solo lo seguira porque esta mas lejos
            anim.SetBool("Golpear",false);//Se desactiva el golpear por que esta muy lejos 
        }

        if (anim.GetBool("Golpear"))//Si Golpea se congelan los 3 ejes
        {
            rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
        else // En caso que no, El movimiento sigue 
        {
            rb2d.constraints = RigidbodyConstraints2D.None | RigidbodyConstraints2D.FreezeRotation;
        }

        if (sp.sprite.name == ("Invisible_0"))//Llamamos al sprite invisible para destruir al enemigo 
        {
            //anim.enabled = false;//Cuando sus sprites de presencia sean falsos osea terminen
            //sp.enabled = false;//Este se destruye
            bc.enabled = false;
            Destroy(gameObject);//Destruye al objeto
        }
        
        
        if (target == initialPosition && distance < 0.01f)//Si el objetivo permanece lejos y no lo reconoce por la gran distancia que hay
        {
            
            transform.position = initialPosition;//Se vuelve a la posicion inicial
            anim.SetBool("Seguir", false);//Y se desactiva la animacion de seguimiento 
        }
        Debug.DrawLine(transform.position , target, Color.green);//Se crea el debug para reconer su campo de vision y saber la ubicacion del objetivo
        
    }
    
}