using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public float timeTillMorning;
    public bool partOne, partTwo, partThree, horde;
    public GameObject clueCard;
    private bool gameOver;
    public TMP_Text overlayText;
    private bool gateUnlocked;
    public ParanormalController PC;


    public void Start()
    {
        partOne = true;
        PC = GetComponent<ParanormalController>();
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
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            PC.firstHunt = true;
        }
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
        Debug.Log("gate unlocked");
    }

    public void GameOver()
    {
        Debug.Log("game over");
    }
}
