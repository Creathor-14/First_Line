using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class SaveLoadGame: MonoBehaviour
{
    public GameObject playerMove;

    public void Guardar()
    {
        GameObject player = GameObject.FindWithTag("Player");
        string data = string.Empty;
        Vector3 posPlayer; 
        
        posPlayer = player.transform.position;
        data = posPlayer.x + ";" + posPlayer.y + ";" + posPlayer.z;
        Debug.Log(data);
        PlayerPrefs.SetString("Player",data);
        PlayerPrefs.Save();
    }

    public void Vacio()
    {
        Destroy(playerMove);
    }

    public void Cargar()
    {
        string data = PlayerPrefs.GetString("Player",String.Empty);
        Debug.Log(data);
        string coma = ";";

        string[] ejes = data.Split(coma.ToCharArray());
        
        Debug.Log(ejes[0]);
        Vector3 pos = Vector3.zero;
        
        pos.x = float.Parse(ejes[0]); 
        pos.y = float.Parse(ejes[1]);
        Vacio();
        Instantiate(this.playerMove, pos,Quaternion.identity);
    }

}