using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tool_goToScene : MonoBehaviour
{
    [SerializeField] string loadSceneName;

    public void goToScene(){
        SceneManager.LoadScene(loadSceneName);
    }
}
