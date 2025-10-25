using UnityEngine;

using System;               ////Stuff from Button.cs
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;    ////Stuff from Button.cs  end

public class tool_onKeyPress : MonoBehaviour
{
    [SerializeField] KeyCode triggerKey;

    [Serializable]      //Stuff from Button.cs      (No idea what it is, just using it)
    public class KeyPressEvent : UnityEvent {}
    [FormerlySerializedAs("onKeyPress")]
    [SerializeField]
    private KeyPressEvent KeyPress = new KeyPressEvent();   ////Stuff from Button.cs    end
        
    void Update()
    {
        if(Input.GetKeyDown(triggerKey)){
            KeyPress.Invoke();      //Stuff from Button.cs       Use this to do the function
        }
    }
}
