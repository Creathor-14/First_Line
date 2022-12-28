using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovil : MonoBehaviour
{
    public Transform target;
    public float speed;

    //private Vector3 start, end;
    void Start()
    {
        if (target != null)
        {
            target.parent = null;
            /*
            start = transform.position; // toma la posicion inicial de la plataforma
            end = target.position; // toma la posicion del "target"
            */
        }
    }
    

    private void FixedUpdate()
    {
        if (target != null)
        {
            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target.position, fixedSpeed);
        }
        
        /*
        if (transform.position == target.position)
        {
            target.position = (target.position == start) ? end : start; // comprueba la posicion del target, se verifica si esta en start. Si no lo esta target.position == start, else target.position == end
        }
        */
    }
}
