using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
//这个不用模仿我写的那个
public class switchScenes : MonoBehaviour
{
    public List<GameObject> SceneList;
    public void SwitchScenes(int scene_id){
          foreach(var scene in SceneList){
              scene.SetActive(false);
          }
          SceneList[scene_id].SetActive(true);
    }
}
