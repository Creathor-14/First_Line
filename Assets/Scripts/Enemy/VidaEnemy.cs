using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaEnemy : MonoBehaviour
{
    public float vida = 100;
    
    public Image barraVida;
    //public Image fondo;
    //public Image fondo1;
    
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraVida.fillAmount = vida / 100;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*invs
        var aja = barraVida.color;
        var aje = fondo.color;
        var aji = fondo1.color;
        */
        if (collision.gameObject.tag == "Attack")
        {
            vida -= 10f;
            /*invs
            aja.a = 255f;
            aje.a = 255f;
            aji.a = 255f;
            */
            
        }
        else if (collision.gameObject.tag == "golpeCuchillo")
        {
            vida -= 5f;
        }

        else if (collision.gameObject.tag == "AtakEspada")
        {
            vida -= 5f;
        }

        else if (collision.gameObject.tag == "AtakMordida")
        {
            vida -= 5f;
        }

        else if (collision.gameObject.tag == "GolpeMazo")
        {
            vida -= 5f;
        }
        /*invs
        else
        {
            aja.a = 25f;
            aje.a = 25f;
            aji.a = 25f;
            
        }
        barraVida.color = aja;
        fondo.color = aje;
        fondo1.color = aji;
        */
        
        

    }
}
