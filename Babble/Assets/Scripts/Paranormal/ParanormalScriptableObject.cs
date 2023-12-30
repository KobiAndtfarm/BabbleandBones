using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/Paranormal")]
public class ParanormalScriptableObject : ScriptableObject
{
    public string Itemname;

    public string ItemType;

    public string[] Weakness;

    public GameObject prefab;

 
}
