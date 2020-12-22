using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaPlaye : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    private Rigidbody2D rb;
    private Vector2 Control;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3 mov = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"),0);
        transform.position = Vector3.MoveTowards(transform.position, transform.position + mov, Time.deltaTime * Speed);
        object mover;
        Control = mover.normalized * Speed;
    }

    public Vector2 Control1 { get; set; }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Control * Time.deltaTime);
    }
    
}
