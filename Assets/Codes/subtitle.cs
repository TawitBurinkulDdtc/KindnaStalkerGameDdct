using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class subtitle : MonoBehaviour
{

    public TextMeshProUGUI textUI;
    //public Color c;

    public void Say(string input){
        textUI.text = input;
       // c = new Color(1,1,0,0);
    }
    public void Say(string input,int r,int g,int b){
        Color newColor = new Color(r/255f,g/255f,b/255f,1);
        textUI.color = newColor;
        textUI.text = input;
    }
    public void Font(int input){
        textUI.fontSize = input;
    }
    
    
   
}
