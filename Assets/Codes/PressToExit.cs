using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressToExit : MonoBehaviour
{
    [SerializeField] KeyCode kc;

    void Update()
    {
        if(Input.GetKeyDown(kc)){
            Application.Quit();
        }
    }
}
