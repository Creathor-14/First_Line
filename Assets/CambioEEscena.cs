using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CambioEEscena : MonoBehaviour
{
    public Button boton;

    private void Awake()
    {
        CantEnemy.cantEnemy = 0;
    }
    
    void Start()
    {
        boton.gameObject.SetActive(false);
    }
    
    public void Escena2()
    {
        SceneManager.LoadScene("Level_2");
        Debug.Log("cambio");
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
        if (CantEnemy.cantEnemy == 26)
        {
            CantEnemy.cantEnemy = 0;
            boton.gameObject.SetActive(true);
        }

    }
}
