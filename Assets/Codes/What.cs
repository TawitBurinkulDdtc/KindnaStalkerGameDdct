using UnityEngine;

public class What : MonoBehaviour
{
      public Material Material1;
    //in the editor this is what you would set as the object you wan't to change
    public GameObject Object;

    void Start()
    {
         Object.GetComponent<MeshRenderer>().material = Material1;
    }
}
