using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAAAaaa : MonoBehaviour
{
    public ScriptableObject scr;
    // Start is called before the first frame update
    void Start()
    {
        scr = GetComponent<ScriptableObject>();
    }

    // Update is called once per frame
    void Update()
    {
        print(scr.name);
    }
}
