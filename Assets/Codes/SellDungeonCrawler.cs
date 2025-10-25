using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

public class SellDungeonCrawler : MonoBehaviour
{
    [SerializeField] List<string> words; //note: Could made this into tool code instead.
    [SerializeField] subtitle sub;
    [SerializeField] KeyCode kc;
    [Header("diejowofjowjfo3jfo")]
    [SerializeField] List<GameObject> item;
    [SerializeField] GameObject buttonObj;
    [SerializeField] subtitle subButtonA;
    [SerializeField] subtitle subButtonB;
    
    bool end = false;
    int n;
    bool openOnce = false;
    bool doOnce = false;
    int itemN = 0;
    int itemN2 = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(n < words.Count){
            if (Input.GetKeyDown(kc)){
                sub.Say(words[n]);
                n=n+1;
            }
        }
        else if(!openOnce){
            if(!doOnce){
                buttonObj.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                doOnce = true;
            }
            itemN = Random.Range(0,item.Count);
            itemN2 = Random.Range(0,item.Count);
            subButtonA.Say(item[itemN].name);
            subButtonB.Say(item[itemN2].name);
            if(itemN2 != itemN){
                openOnce = true;
            }
        }
    }

    public void chooseItem(int input){
        if(input == 1){
            item[itemN].SetActive(true);
        }
        else if(input == 2){
            item[itemN2].SetActive(true);
        }
    }

    public void closeUi(){
        buttonObj.SetActive(false);
        sub.Say(" ");
        Cursor.lockState = CursorLockMode.Locked;
    }

}
