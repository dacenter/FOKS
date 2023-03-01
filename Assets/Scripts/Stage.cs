using System;
using UnityEngine;

[Serializable]
[CreateAssetMenu(menuName = "Stage")]
public class Stage:ScriptableObject
{
    [field:SerializeField]
    public int SceneIndex { get; set; }
                
    [field:SerializeField]
    public string StageName { get; set; }
                
    [field:SerializeField]
    public Sprite SceneImage { get; set; }
                
    [field:SerializeField]
    public bool Active { get; set; }
}