using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CambioEEscena : MonoBehaviour
{
    public VidaEnemy VidaE;

    public GameObject bot;

    private void Awake()
    {
        CantEnemy.cantEnemy = 0;
    }
    
    void Start()
    {
        bot.SetActive(false);
    }
    
    public void E2()
    {
        SceneManager.LoadScene("Level_2");
    }
    
    public void E3()
    {
        SceneManager.LoadScene("Level_new");
    }
    
    public void E5()
    {
        SceneManager.LoadScene("Levels/Level_5/Level_LaMoneda/Level_LaMoneda");
    }

   

    // Update is called once per frame
    void Update()
    {
        if (CantEnemy.cantEnemy == 60)
        {
            CantEnemy.cantEnemy = 0;
            bot.SetActive(true);
            
        }

    }
}
