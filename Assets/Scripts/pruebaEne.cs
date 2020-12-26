using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaEne : MonoBehaviour
{
    Vector2 Enemypos;
    public GameObject PlayerM;
    bool perseguir;
    public int vel;
    private Animator anim;
    public float Speed;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if (perseguir)
        {
            transform.position = Vector2.MoveTowards(transform.position, Enemypos, vel * Time.deltaTime);
            anim.SetBool("Seguir", true);

        }

        if (Vector2.Distance(transform.position, Enemypos) > 12f)
        {
            perseguir = false;
            anim.SetBool("Seguir",false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Enemypos = PlayerM.transform.position;
            perseguir = true;
        }
    }
    
}