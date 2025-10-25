using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tool_2dSpriteCutScene : MonoBehaviour
{
    [Header("All list need to have same amount")]
    [SerializeField] Image imageDisplay;
    [SerializeField] subtitle sub;
    [SerializeField] KeyCode kc;
    
    public int n = -1;

    public List<SceneVar> sv;

    [System.Serializable]
    public struct SceneVar
    {
        public Sprite pic;
        public bool changePic;
        public string text;
        public bool changeText;

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(kc))
        {
            n = n+1;
            if(n < sv.Count){
                if(sv[n].changePic == true){
                    imageDisplay.sprite = sv[n].pic;
                }
                if(sv[n].changeText == true){
                    sub.Say(sv[n].text);
                }
            }
        }
    }
}
