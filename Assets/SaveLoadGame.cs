using System;
using UnityEngine;
using UnityEngine.Rendering;

public class SaveLoadGame: MonoBehaviour
{
    public GameObject playerMove;

    public void Guardar()
    {
        GameObject player = GameObject.FindWithTag("Player");
        string data = "";
        Vector3 posPlayer; 
        posPlayer = player.transform.position;
        data = posPlayer.x +", "+ posPlayer.y;
        Debug.Log(data);
        PlayerPrefs.SetString("Player",data);
        PlayerPrefs.Save();
    }

    public void Cargar()
    {
        string data = PlayerPrefs.GetString("Player",String.Empty);

        Debug.Log(data.Length);
        string[] ejes = data.Split();
        Vector3 pos = Vector3.zero;
        
        pos.x = float.Parse(ejes[0]);
        pos.y = float.Parse(ejes[1]);

        Instantiate(this.playerMove, pos,Quaternion.identity);
    }

}