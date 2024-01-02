using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Forest : MonoBehaviour
{
    public ClueCard CC;
    public GameObject[] dollSets;

    public void Start()
    {
        CC = GetComponent<ClueCard>();
    }
    private void OnEnable()
    {
        if (CC.clueAnswer == "1")
        {
            dollSets[1].SetActive(true);
            GameObject.Find("campfire").SetActive(true);
        }
        if (CC.clueAnswer == "2")
        {
            dollSets[2].SetActive(true);
            GameObject.Find("minecart").SetActive(true);
        }
        if (CC.clueAnswer == "3")
        {
            dollSets[3].SetActive(true);
            GameObject.Find("wheelbarrow").SetActive(true);
        }
        if (CC.clueAnswer == "4")
        {
            dollSets[4].SetActive(true);
            GameObject.Find("crates").SetActive(true);
        }
        if (CC.clueAnswer == "5")
        {
            dollSets[5].SetActive(true);
            GameObject.Find("well").SetActive(true);
        }
        if (CC.clueAnswer == "6")
        {
            dollSets[6].SetActive(true);
            GameObject.Find("scarecrow").SetActive(true);
        }
        if (CC.clueAnswer == "7")
        {
            dollSets[7].SetActive(true);
            GameObject.Find("campfire").SetActive(true);
        }
        if (CC.clueAnswer == "8")
        {
            dollSets[8].SetActive(true);
            GameObject.Find("minecart").SetActive(true);
        }
        if (CC.clueAnswer == "9")
        {
            dollSets[9].SetActive(true);
            GameObject.Find("wheelbarrow").SetActive(true);
        }
        if (CC.clueAnswer == "10")
        {
            dollSets[10].SetActive(true);
            GameObject.Find("crates").SetActive(true);
        }
        if (CC.clueAnswer == "11")
        {
            dollSets[11].SetActive(true);
            GameObject.Find("well").SetActive(true);
        }
        if (CC.clueAnswer == "12")
        {
            dollSets[12].SetActive(true);
            GameObject.Find("scarecrow").SetActive(true);
        }
    }

    public void OnDisable()
    {
        for (int i = 0; i < dollSets.Length; i++)
        {
            dollSets[i].SetActive(false);
        }
    }
}
