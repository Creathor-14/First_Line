using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesTrucho : MonoBehaviour
{
    private SpriteRenderer sp;
    private BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        bc = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collicion)
    {
        if (collicion.gameObject.tag == "Player")
        {
            sp.enabled = false;
            bc.enabled = false;
        }
    }
}
