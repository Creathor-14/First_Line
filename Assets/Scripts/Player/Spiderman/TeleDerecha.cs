using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleDerecha : MonoBehaviour
{
    public GameObject TeleD;
    public GameObject a;
    public GameObject b;
    public GameObject c;
    public GameObject d;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (TeleD.gameObject.activeSelf)
        {
            a.gameObject.SetActive(true);
        }
        //teleD.gameObject.SetActive(true);
        a.gameObject.SetActive(true);
        StartCoroutine("Esperar");
        a.gameObject.SetActive(false);
                
        b.gameObject.SetActive(true);
        StartCoroutine("Esperar");
        b.gameObject.SetActive(false);
                
        c.gameObject.SetActive(true);
        StartCoroutine("Esperar");
        c.gameObject.SetActive(false);
                
        d.gameObject.SetActive(true);
        StartCoroutine("Esperar");
        d.gameObject.SetActive(false);
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(1);
    }
    
}
