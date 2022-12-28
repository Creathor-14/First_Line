using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golpes : MonoBehaviour
{
    private SpriteRenderer sp;
    private Animator anim;
    public piraña piraña;
    
    //derecha
    public BoxCollider2D d1;
    public BoxCollider2D d2;
    public BoxCollider2D d3;
    public BoxCollider2D d4;
    public BoxCollider2D d5;
    //izquierda
    public BoxCollider2D iz1;
    public BoxCollider2D iz2;
    public BoxCollider2D iz3;
    public BoxCollider2D iz4;
    public BoxCollider2D iz5;
    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        int tipoAtak = piraña.tipoAtaque;
        if (sp.flipX == false)//derecha
        {
            if (tipoAtak==1)//ataque1
            {
                if (sp.sprite.name == "Piraña_26")
                {
                    d1.enabled = true; 
                }
                else
                {
                    d1.enabled = false; 
                }
            }
            
            if(tipoAtak==2)//ataque4
            {
                if (sp.sprite.name == "Piraña_29")
                {
                    d2.enabled = true; 
                }
                else
                {
                    d2.enabled = false; 
                }
                
            }
            
            if(tipoAtak==3)//ataque2
            {
                if (sp.sprite.name == "Piraña_34")
                {
                    d3.enabled = true; 
                }
                else
                {
                    d3.enabled = false; 
                }
                
            }
            if(tipoAtak==4)//ataque3
            {
                if (sp.sprite.name == "Piraña_37")
                {
                    d4.enabled = true; 
                }
                else
                {
                    d4.enabled = false; 
                }
                
            }
            if(tipoAtak==5)//ataque4
            {
                if (sp.sprite.name == "Piraña_59")
                {
                    d5.enabled = true; 
                }
                else
                {
                    d5.enabled = false; 
                }
                
            }
            
            
            
        }
        else
        {
            if (tipoAtak==1)//ataque1
            {
                if (sp.sprite.name == "Piraña_26")
                {
                    iz1.enabled = true; 
                }
                else
                {
                    iz1.enabled = false; 
                }
            }
            
            if(tipoAtak==2)//ataque4
            {
                if (sp.sprite.name == "Piraña_29")
                {
                    iz2.enabled = true; 
                }
                else
                {
                    iz2.enabled = false; 
                }
                
            }
            
            if(tipoAtak==3)//ataque2
            {
                if (sp.sprite.name == "Piraña_34")
                {
                    iz3.enabled = true; 
                }
                else
                {
                    iz3.enabled = false; 
                }
                
            }
            if(tipoAtak==4)//ataque3
            {
                if (sp.sprite.name == "Piraña_37")
                {
                    iz4.enabled = true; 
                }
                else
                {
                    iz4.enabled = false; 
                }
                
            }
            if(tipoAtak==5)//ataque4
            {
                if (sp.sprite.name == "Piraña_59")
                {
                    iz5.enabled = true; 
                }
                else
                {
                    iz5.enabled = false; 
                }
                
            }       
            
                
        }
    }
}
