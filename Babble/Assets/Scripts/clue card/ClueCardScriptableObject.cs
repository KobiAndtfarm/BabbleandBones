using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "My Assets/CluecardElement")]
public class ClueCardScriptableObject : ScriptableObject
{
    public string color;
    public string redSymbol, whiteSymbol,bluePrefabName;
    public GameObject colorPrefab, redSymbolPrefab, whiteSymbolPrefab, bluePrefab;

    public string[] doll, room, cavePattern;

}
