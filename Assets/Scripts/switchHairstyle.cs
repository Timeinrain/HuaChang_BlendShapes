using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class switchHairstyle : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]//
    public List<GameObject> hairStyleList;
    // public list<material> list
    public List<Button> SwitchHairStyleButtonGroup;
    
    static int haircount = 2;
   

    public void SwitchHairStyle(int i){
        foreach(var HStyle in hairStyleList){
            HStyle.SetActive(false);
        }
        hairStyleList[i].SetActive(true);
    }
}
