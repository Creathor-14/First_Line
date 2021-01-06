using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DAÑOAPLAY : MonoBehaviour
{
    NavMeshAgent Agent;
    
    float Dist;
    public float DistanciaPerseguir = 15f;
    public float DistanciaAtaque = 3f;
    public float TiempoAtaque = 2f;

    public bool Persegir = false;
    public float TiempoD = 5f;

    Transform Player;
    VidaPlayer PlayerVida;

    public int DañoEnemigo = 10;
    // Para inicializar 
    void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
        Player = GameObject.FindGameObjectWithTag("Player").transform;
        PlayerVida = Player.GetComponent<VidaPlayer>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        Dist = Vector3.Distance(Player.position, transform.position);
        if (Dist <= DistanciaPerseguir)
        {
            Persegir = true;
            TiempoD = 5f;
        }
        else
        {
            TiempoD -= Time.deltaTime;
            if (TiempoD <= 0)
            {
                TiempoD = 5f;
                Persegir = false;
            }
        }

        if (Persegir == true)
        {
            Agent.SetDestination(Player.position);
            if (Dist <= DistanciaAtaque)
            {
                TiempoAtaque -= Time.deltaTime;
                if (TiempoAtaque <= 0)
                {
                    PlayerVida.vida -= DañoEnemigo;
                    TiempoAtaque = 2f;
                }
            }
            else
            {
                TiempoAtaque = 2f;
            }
        }
        
    }
}
