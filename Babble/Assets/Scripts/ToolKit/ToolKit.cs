using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolKit : MonoBehaviour
{
    public List<string> selectedTools;
    public Creature creature;
    public string pressedTool;
    public int currentToolNumber=0;
    public ParanormalController paraC;
    public GameController GC;

    private void Start()
    {
        paraC = GetComponent<ParanormalController>();
        GC = GetComponent<GameController>();
    }
    private void Update()
    {
        CheckIfFinished();
    }
    public void ToolPressed()
    {
        selectedTools.Add(pressedTool);
        currentToolNumber += 1;
    }
    public void CheckIfFinished()
    {
        if(currentToolNumber == creature.toolsRequired.Count)
        {
            if (selectedTools == creature.toolsRequired)
            {
                paraC.eventEnd = true;
                Debug.Log("paranormal defeated");
                creature.OnDeath();
             
                currentToolNumber = 0;
                selectedTools.Clear();
                
            }
            else 
            {
                GC.GameOver();
            }

        }
    }
    
    
}
