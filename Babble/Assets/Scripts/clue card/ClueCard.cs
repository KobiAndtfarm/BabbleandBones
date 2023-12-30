using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueCard : MonoBehaviour
{
    public ClueCardScriptableObject[] color;
    public ClueCardScriptableObject[] redSymbols;
    public ClueCardScriptableObject[] blue;
    public ClueCardScriptableObject[] whiteSymbols;

    public Vector3 position;
    private string currentClueCardColor;
    public string clueAnswer;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void OnEnable()
    {
        foreach(ClueCardScriptableObject clueObj in color)
        {
            int i = Random.Range(0, 3);
            currentClueCardColor = color[i].color;

            //might wish to do this in scene seting UI active
            color[i].colorPrefab = Resources.Load(color[i].color) as GameObject;
            Instantiate(color[i].colorPrefab, position, Quaternion.identity);
        }
        if(currentClueCardColor == "Red")
        {
            Red();
            Debug.Log("redClue");
        }
        if(currentClueCardColor == "Blue")
        {
            Blue();
            Debug.Log("blueClue");
        }
        if(currentClueCardColor == "White")
        {
            White();
            Debug.Log("whiteClue");
        }
        else
        {
            Debug.Log("no color assigned");
        }
    }

    public void Red()
    {
        foreach(ClueCardScriptableObject symbolObj in redSymbols)
        {
            int i = Random.Range(0, redSymbols.Length + 1);
            redSymbols[i].redSymbolPrefab = Resources.Load(redSymbols[i].redSymbol) as GameObject;
            Instantiate(redSymbols[i].redSymbolPrefab, position, Quaternion.identity);
            redSymbols[i].room[i] = clueAnswer;
        }

    }
    public void Blue()
    {
       foreach(ClueCardScriptableObject blueobj in blue)
       {
            int i = Random.Range(0, blue.Length + 1);
            blue[i].bluePrefab = Resources.Load(blue[i].bluePrefabName) as GameObject;
            Instantiate(blue[i].bluePrefab, position, Quaternion.identity);
            blue[i].cavePattern[i] = clueAnswer;
       }
    }
    public void White()
    {
        foreach (ClueCardScriptableObject symbolObj in whiteSymbols)
        {
            int i = Random.Range(0, whiteSymbols.Length + 1);
            whiteSymbols[i].whiteSymbolPrefab = Resources.Load(whiteSymbols[i].whiteSymbol) as GameObject;
            Instantiate(whiteSymbols[i].whiteSymbolPrefab, position, Quaternion.identity);
            whiteSymbols[i].doll[i] = clueAnswer;
        }
    }
}
