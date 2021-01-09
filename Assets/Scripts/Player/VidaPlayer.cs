using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraVida;
    public Image barraArmadura;
    private int cont = 0;
    public int DañoEnemigo = 10;

    
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        if (barraArmadura.fillAmount.ToString().Equals("0"))
        {
            barraVida.fillAmount = vida / 100;
            //print("La vida actual es: "+barraVida.fillAmount.ToString());
        }
        else
        {
            barraArmadura.fillAmount = vida / 100;
            //print("La armadura actual es: "+barraArmadura.fillAmount.ToString());
        }

        if (barraArmadura.fillAmount.ToString().Equals("0") && cont==0) //pasa el a la imagen vida para bajarle a la vida despues de la armadura
        {
            vida = 100;
            cont += 1;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyAtk")
        {
            vida -= 10f;

        }
        if (collision.gameObject.tag == "golpeCuchillo")
        {
            vida -= 5f;
        }

        if (collision.gameObject.tag == "AtakEspada")
        {
            vida -= 5f;
        }

        if (collision.gameObject.tag == "AtakMordida")
        {
            vida -= 5f;
        }
    }
}

