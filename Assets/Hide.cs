using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour

{
public Canvas hide;
public bool Switcher=false;

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            hide.enabled = Switcher;
            Switcher = !Switcher;
        }    
    }
}
