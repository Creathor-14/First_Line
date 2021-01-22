using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vidaBoss : MonoBehaviour
{
    public float vidaReal;
    public float vida;
    private SpriteRenderer barraVida;
    private Animator anim;
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        bc = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (vida > 0)
        {
            float daño;
            //mujer(PL)
            if (collision.gameObject.tag == "PL(golpe-normal)")
            {
                daño = 44f;
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");

            }

            if (collision.gameObject.tag == "PL(golpe-especial)")
            {
                daño = 64f;
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //matapaco
            if (collision.gameObject.tag == "MP(mordisco)")
            {
                daño = 66f;
                vida -= daño;
                daño /= vidaReal;
                //AGREGAR SANGRADO
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //karateka
            if (collision.gameObject.tag == "K(golpe)")
            {
                daño = 1; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "K(patada)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "K(patada2)")
            {
                daño = 20; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //hombre(PL)
            if (collision.gameObject.tag == "HPL(golpe)")
            {
                daño = 40f; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "HPL(patada)")
            {
                daño = 55f; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //emprendedor
            if (collision.gameObject.tag == "E(golpe)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "E(golpe2)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;

                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "E(baston1)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;

                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "E(baston2)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //Sensual Spiderman(o por dios pero mira que sensual)
            if (collision.gameObject.tag == "HPL(golpe1)")
            {
                daño = 10; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "HPL(golpe2)")
            {
                daño = 20; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            if (collision.gameObject.tag == "SM(golpe3)")
            {
                daño = 30; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }

            //cuando esta en telearaña
            if (collision.gameObject.tag == "0" || collision.gameObject.tag == "1" || collision.gameObject.tag == "2" ||
                collision.gameObject.tag == "3")
            {
                daño = 1000; //cambiar daño
                vida -= daño;
                daño /= vidaReal;
                barraVida.size -= new Vector2(daño, 0f);
                anim.Play("daño");
            }
        }
    }
}
