using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageInv : MonoBehaviour
{
    
    public float vida = 100;
    public Image barravida;
    public Image fondo;
    public Image fondo1;


    // Start is called before the first frame update
    void Start()
    {
        barravida = GetComponent<Image>();
        fondo = GetComponent<Image>();
        fondo1 = GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barravida.fillAmount = vida / 100;
        /*
        var aja = image.color;
        aja.a = 0f;
        image.color = aja;
        */
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var aja = barravida.color;
        var aje = fondo.color;
        var aji = fondo1.color;
        
        if (collision.gameObject.tag == "Player")
        {
            vida -= 10f;
            aja.a = 20f;
            barravida.color = aja;
            fondo.color = aje;
            fondo1.color = aji;
            print("dafjdasjfsjñdsjafjsad");
        }
        
        
        aja.a = 255f;
        aje.a = 255f;
        aji.a = 255f;
        barravida.color = aja;
        fondo.color = aje;
        fondo1.color = aji;
    }
    
    
}



