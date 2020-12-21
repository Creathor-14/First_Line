using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combates : MonoBehaviour
{
    public bool cantInputAtk;
    public bool inputAtk;
    public static Combates instance;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Attak()
    {
        if (Input.GetButtonDown("space"))
        {
            if (cantInputAtk)
            {
                inputAtk = true;
                cantInputAtk = false;
            }
            else
            {
                return;
            }
        }
    }


    public void IngresoInput()
    {
        if (!cantInputAtk)
        {
            cantInputAtk = true;
        }
        else
        {
            cantInputAtk = false;
        }
    }
}
