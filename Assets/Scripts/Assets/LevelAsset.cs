using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace Assets{
[CreateAssetMenu(menuName ="Assets/Level Asset",fileName = "Assets/LevelAsset")]
public class LevelAsset : ScriptableObject

{
    public SceneAsset SceneAsset;
    
}

}