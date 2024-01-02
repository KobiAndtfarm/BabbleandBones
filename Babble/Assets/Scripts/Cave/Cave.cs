using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : MonoBehaviour
{
    public ClueCard CC;
    void Start()
    {
        CC = GetComponent<ClueCard>();
    }

   
    void OnEnable()
    {
        if(CC.clueAnswer == "minecart")
        {
            GameObject.Find("minecart").SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(CC.clueAnswer == "well")
        {
            GameObject.Find("well").SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(CC.clueAnswer == "campfire")
        {
            GameObject.Find("campfire").SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(CC.clueAnswer == "crates")
        {
            GameObject.Find("crates").SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(CC.clueAnswer == "scarecrow")
        {
            GameObject.Find("scarecrow").SetActive(true);
            this.gameObject.SetActive(false);
        }
        if(CC.clueAnswer == "wheelbarrow")
        {
            GameObject.Find("wheelbarrow").SetActive(true);
            this.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("something is broken incorrect name for clueAnswer? clue answer cant be found");
        }
        
    }
}
