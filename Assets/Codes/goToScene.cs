using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToScene : MonoBehaviour
{
    [SerializeField] string nextSceneName;
    [SerializeField] KeyCode thisOne;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(thisOne)){
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
