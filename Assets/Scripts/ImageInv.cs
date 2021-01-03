using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageInv : MonoBehaviour
{
    public Image image;

    private int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cont == 0)//aparece la imagen
        {
            image.color = new Color(255,255,0,255); 
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            image.color = new Color(255,255,255,27);//desvanece la imagen
            cont += 1;
            print("Fire1");
        }

        if (Input.GetButtonDown("Fire2"))
        {
            cont = 0;
            print("Fire2");
        }
    }

    
}
