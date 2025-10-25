using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    
public CharacterController controller;
public float speed = 12f;
public float gravity = -9.81f;
public bool playerControl = true;


Vector3 falling;

    void Start()
    {    }

    void moving(){
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");  
        Vector3 move = transform.right * x + transform.forward * z;
        move.Normalize();
        if (Input.anyKey){
            if (Input.GetKey("w")||Input.GetKey("a")||Input.GetKey("s")||Input.GetKey("d")){
                controller.Move(move*speed*Time.deltaTime);     //Fix this one, it make movement feel horrible.
            }
        }
        falling.y = gravity*Time.deltaTime;
        controller.Move(falling);
    }

    void Update()
    {
    
        if(playerControl == true){
            moving();
        }
    
    }
   
}
