using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolKit : MonoBehaviour
{
    public List<string> selectedTools;
    public Ghost ghost;
    public Zombie zombie;
    public Mummy mummy;
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
        if(currentToolNumber == ghost.toolsRequired.Count)
        {
            if (selectedTools == ghost.toolsRequired)
            {
                paraC.eventEnd = true;
                Debug.Log("paranormal defeated");
                ghost.OnDeath();
                zombie.OnDeath();
                mummy.OnDeath();
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
