using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaEne : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject playerM;
    bool perseguirP;
    public float speed = 3f;
    
    // Update is called once per frame
    void Update()
    {
        if (perseguirP)
        {
            transform.position = Vector2.MoveTowards(transform.position, Enemypos, speed * Time.deltaTime);
        }

        if (Vector3.Distance(transform.position, Enemypos) > 4f)
        {
            perseguirP = false;
        }
    }

    public Vector2 Enemypos { get; set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag.Equals("Player"))
        {
            Enemypos = playerM.transform.position;
            perseguirP = true;
        }
    }
}
