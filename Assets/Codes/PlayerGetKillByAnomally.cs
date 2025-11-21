using UnityEngine;

public class PlayerGetKillByAnomally : MonoBehaviour
{

    public string tagName;
    [SerializeField] GameObject deadUi;
    [SerializeField] PlayerMovement pm;
    void OnTriggerEnter(Collider other){
       if(other.gameObject.tag == tagName){
            deadUi.SetActive(true);
            pm.gravity = 60.0f;
        }
    }
}
