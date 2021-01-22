using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CantEnemy:MonoBehaviour
{
    public static int cantEnemy;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        cantEnemy = 0;
    }

    private void Update()
    {
        text.text= "Centinelas Derrotados:" + cantEnemy;
    }
}
