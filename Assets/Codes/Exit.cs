using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    [SerializeField] string nextSceneName;

    void OnTriggerEnter(Collider other){
        if(other.gameObject.name == "Player"){
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
