using System;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class SaveLoadGame: MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (LOAD.carga)
            player.transform.position = new Vector3(PlayerPrefs.GetFloat("Player x"),PlayerPrefs.GetFloat("Player y"),0);
    }

    public void Guardar()
    {
        PlayerPrefs.SetFloat("Player x",player.transform.position.x);
        PlayerPrefs.SetFloat("Player y", player.transform.position.y);

        PlayerPrefs.Save();
    }

    public void Borrar()
    {
        PlayerPrefs.DeleteKey("Player x");
        PlayerPrefs.DeleteKey("Player y");
    }

}