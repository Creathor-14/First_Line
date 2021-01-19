using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraVida;
    public float armadura = 100;
    public Image barraArmadura;
    private int cont = 0;
    public int DañoEnemigo = 10;
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        armadura = Mathf.Clamp(armadura, 0, 100);
        if (barraArmadura.fillAmount.ToString().Equals("0"))
        {
            barraVida.fillAmount = vida / 100;
        }
        else
        {
            barraArmadura.fillAmount = armadura / 100;
        }
        if (cont==1) //pasa el a la imagen vida para bajarle a la vida despues de la armadura
        {
            barraArmadura.fillAmount = armadura / 100;
            cont = 0;
        }
        if (cont == 2)
        {
            barraVida.fillAmount = vida / 100;
            barraArmadura.fillAmount = armadura / 100;
            cont = 0; 
        }
        //print("La vida actual es: "+barraVida.fillAmount.ToString()+", La armadura actual es: "+barraArmadura.fillAmount.ToString());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Golpes Enemigos
        if (collision.gameObject.tag == "EnemyAtk")
        {
            if (barraArmadura.fillAmount.ToString().Equals("0"))
            {
                vida -= 10f; 
            }
            else
            {
                armadura -= 10f;
            }
        }

        if (collision.gameObject.tag == "golpeCuchillo")
        {
            if (barraArmadura.fillAmount.ToString().Equals("0"))
            {
                vida -= 5f; 
            }
            else
            {
                armadura -= 5f;
            }
        }

        if (collision.gameObject.tag == "AtakEspada")
        {
            if (barraArmadura.fillAmount.ToString().Equals("0"))
            {
                vida -= 105f; 
            }
            else
            {
                armadura -= 105f;
            }
        }

        if (collision.gameObject.tag == "AtakMordida")
        {
            vida -= 5f;
        }

        if (collision.gameObject.tag == "GolpeMazo")
        {
            vida -= 5f;
        }

        //Consumibles
        if (collision.gameObject.tag == "Vinito")
        {
            vida += 100f;
        }
        if (collision.gameObject.tag == "Handroll")
        {
            vida += 50f;
        }
        if (collision.gameObject.tag == "Empanada")
        {
            vida += 10f;
        }
        if (collision.gameObject.tag == "Poncho")
        {
            armadura += 100f;
            cont = 1;
        }
        if (collision.gameObject.tag == "Chupalla")
        {
            armadura += 50f;
            cont = 1;
        }
        if (collision.gameObject.tag == "Kapo")
        {
            armadura += 10f;
            cont = 1;
        }

        if (collision.gameObject.tag == "PoleraChile")
        {
            armadura += 100f;
            vida += 100f;
            cont = 2;
        }
    }
}


