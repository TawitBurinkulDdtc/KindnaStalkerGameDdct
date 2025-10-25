using UnityEngine;

public class PlayerGetKillByAnomally : MonoBehaviour
{

    public string tagName;
    [SerializeField] GameObject deadUi;

    void OnTriggerEnter(Collider other){
       if(other.gameObject.tag == tagName){
            deadUi.SetActive(true);
        }
    }
}
