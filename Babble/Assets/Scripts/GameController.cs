using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public float timeTillMorning;
    public bool partOne, partTwo, partThree, horde;
    public GameObject clueCard;
    public TMP_Text overlayText;
    public ParanormalController PC;
    public ClueCard CC;

    public void Start()
    {
        partOne = true;
        PC = GetComponent<ParanormalController>();
        CC = GetComponent<ClueCard>();
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
            GameOver();
        }
    }
    public void PartOne()
    {
        clueCard.SetActive(true);
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            PC.firstHunt = true;
            clueCard.SetActive(false);

        }
    } 
    public void PartTwo()
    {
        clueCard.SetActive(true);
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            clueCard.SetActive(false);
        }
    } 
    public void PartThree()
    {
        overlayText.enabled = true;
        overlayText.text = "You have completed the key, head to the graveyard";
        if (Input.GetKey(KeyCode.Mouse0))
        {
            overlayText.enabled = false;
        }
        GateUnlocked();
        Debug.Log("gate unlocked");
    }

    public void GameOver()
    {
        Debug.Log("game over");
    }

    public void GateUnlocked()
    {

    }
}
