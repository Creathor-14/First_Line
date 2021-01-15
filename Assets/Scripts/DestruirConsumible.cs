using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirConsumible : MonoBehaviour
{
    private GameObject consumible;
    // Start is called before the first frame update
    void Start()
    {
        consumible = GetComponent<GameObject>();
        
    }
    private void OnCollisionEnter2D(Collision2D collicion)
    {
        if (collicion.gameObject.tag == "Player")
        {
            Destroy(consumible);
        }
    }
}
