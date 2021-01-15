using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;
public class RestartLevel : MonoBehaviour
{
    public GameOverManager gameOver;

    public void restartLevel()
    {
        Destroy(gameOver);
        Time.timeScale = 1;
        SceneManager.LoadScene("Nivel_1 luces");
    }
}
