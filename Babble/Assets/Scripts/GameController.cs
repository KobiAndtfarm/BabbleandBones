using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public float timeTillMorning;
    private bool partOne, partTwo, partThree;
    public GameObject clueCard;
    private bool gameOver;
    public TMP_Text overlayText;
    private bool gateUnlocked;


    public void Start()
    {
        partOne = true;
    }
    void Update()
    {
        timeTillMorning -= Time.deltaTime;
        CheckTimer();

        if (partOne)
        {
            PartOne();
        }
        if (partTwo)
        {
            PartTwo();
        }
        if (partThree)
        {
            PartThree();
        }
  

    }
    public void CheckTimer()
    {
        if(timeTillMorning <= 0)
        {
            gameOver = true;
        }
    }
    public void PartOne()
    {
        clueCard.SetActive(true);
    } 
    public void PartTwo()
    {
        clueCard.SetActive(true);
    } 
    public void PartThree()
    {
        overlayText.enabled = true;
        overlayText.text = "You have completed the key, head to the graveyard";
        if (Input.GetKey(KeyCode.Mouse0))
        {
            overlayText.enabled = false;
        }
        gateUnlocked = true;
    }

    public void GameOver()
    {
        Debug.Log("game over");
    }
}
