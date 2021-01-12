using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    
    public VidaPlayer vidaP;
    private Animator anim;
    public GameObject menuPanel,miniMenu;
    
    void Start()
    {
        menuPanel.SetActive(false);
    }
    void Awake()
    {
        anim = GetComponent<Animator>(); // se obtiene la animacion que se agrego al canvas
    }
    
    void Update()
    {
        if (vidaP.barraVida.fillAmount <= 0) 
        {
            menuPanel.SetActive(true);
            anim.SetTrigger("GameOver");
            Time.timeScale = 0;
        }

    }
    
    public void openMiniMenu() // al apretar el boton de volver al menu, se le vuelve a consultar al usuario si esta seguro 
    {
        miniMenu.SetActive(true);
    }

    public void backYES() // se vuelve al menu principal
    {
        menuPanel.SetActive(false);
        miniMenu.SetActive(false);
        SceneManager.LoadScene("Menu");
    }
    
    public void backNo() // regresa al menu de GameOver
    {
        miniMenu.SetActive(false);
    }


}
