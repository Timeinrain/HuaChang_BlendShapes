using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class switchMouth : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]//
    public List<Material> mouthStyleList;//因为是用mesh来控制的所以更改material就可以了，这个模板函数的class换成material
                                         //因为这个是改变body的skinnedmeshrenderer的一个叫做material的component，也就是这个
                                         //这个是嘴唇材质
    public GameObject humanbodyPrefab;
    public List<Texture> MouthTextureList;
    public SkinnedMeshRenderer BodyMesh;
    //这个是我们要加载的物体也就是被贴材质的物体
    public List<Button> SwitchMouthleButtonGroup;
    //这个就是更换的button，用来link逻辑的，前后端的通信
    //你没有安装自动对齐插件吗，我看的好难受hhh
    public void Start()
    {
        BodyMesh = humanbodyPrefab.GetComponentInChildren<SkinnedMeshRenderer>();
        
    }
    public void SwitchMouthStyle(Button button)
    {
        
        //这里的“2”       ↑   指的是这个，然后我们调用我们要更换的那个材质，材质的寻址用button在buttonlist中的下标来映射
        //然后在相应的button上添加逻辑就可以了，上次一样的
        //还有什么问题吗
    }
}
