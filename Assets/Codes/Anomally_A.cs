using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anomally_A : MonoBehaviour
{
    [SerializeField] string name;
    [SerializeField] Transform dir;
    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == name){
            Rigidbody otherRb = other.gameObject.GetComponent<Rigidbody>();
            Vector3 addForce = dir.forward * 40;
            otherRb.AddForce(addForce,ForceMode.Impulse); 
        }
    }
}
