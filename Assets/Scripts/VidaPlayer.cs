using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barraVida;
    
    void Update()
    {
        vida = Mathf.Clamp(vida, 0, 100);
        barraVida.fillAmount = vida / 100;

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "EnemyAtk")
        {
            print("thomy gay");
            vida -= 10f;
        }
    }
}
