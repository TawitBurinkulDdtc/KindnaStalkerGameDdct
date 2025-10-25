using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Ball : MonoBehaviour
{
    [SerializeField] Rigidbody selfRb;
    [SerializeField] Transform playerPoint;
    [SerializeField] KeyCode pressButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Vector3 addForce = player.forward * 20;
        //selfRb.AddForce(addForce,ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(pressButton)){
            selfRb.linearVelocity = Vector3.zero;
            transform.position = new Vector3(playerPoint.position.x, playerPoint.position.y, playerPoint.position.z);
            Vector3 addForce = playerPoint.forward * 4;
            selfRb.AddForce(addForce,ForceMode.Impulse);
        }
    }
}
