using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool : MonoBehaviour
{
    public string toolName;
    public ToolKit TK;

    public void Start()
    {
        TK = GetComponent<ToolKit>();
    }
    public void OnPressed()
    {
        TK.pressedTool = toolName;
    }
}
