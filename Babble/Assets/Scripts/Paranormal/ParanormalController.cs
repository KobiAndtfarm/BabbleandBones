using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParanormalController : MonoBehaviour
{
    public float timeBeforeNextEvent;
    public bool isHunting;
    public bool isTerrorising;
    public GameController GC;
    public bool firstHunt, eventEnd;
    public GameObject[] paranormal;

    public void Start()
    {
        GC = GetComponent<GameController>();
    }
    void Update()
    {
        if (isHunting)
        {
           Hunting();
        }
        else if (isTerrorising)
        {
            Terrorizing();
        }
        else
        {
            StandBy();
        }
    }

    public void FirstHunt()
    {
        GC.overlayText.enabled = true;
        GC.overlayText.text = "The dead are restless now, they may attack at any moment";
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GC.overlayText.enabled = false;
            firstHunt = true;
            StandBy();
            
        }
        
    }

    public void Hunting()
    {
        GC.overlayText.enabled = true;
        GC.overlayText.text = "You are being hunted.";
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GC.overlayText.enabled = false;
            foreach (GameObject paranormalEnemy in paranormal)
            {
                int i = Random.Range(0, 3);
                paranormal[i].SetActive(true);
            }
        }

        //end event
        if(eventEnd) isHunting = false;
    }

    public void Terrorizing()
    {
        GC.overlayText.enabled = true;
        GC.overlayText.text = "You have made an error. The dead are very angry.";
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            GC.overlayText.enabled = false;
            foreach (GameObject paranormalEnemy in paranormal)
            {
                int i = Random.Range(0, 3);
                paranormal[i].SetActive(true);
            }

        }

        //end event
        if (eventEnd) isTerrorising = false;
    }

    public void StandBy()
    {
        if (firstHunt)
        {
            //Randomise when the huntings are triggered
            if (GC.partOne)
            {
                timeBeforeNextEvent = Random.Range(10, 20);
                timeBeforeNextEvent -= Time.deltaTime;
            }
            if (GC.partTwo)
            {
                timeBeforeNextEvent = Random.Range(8, 15);
                timeBeforeNextEvent -= Time.deltaTime;
            }
            if (GC.partThree && GC.horde)
            {
                timeBeforeNextEvent = Random.Range(5, 8);
                timeBeforeNextEvent -= Time.deltaTime;
            }
            else
            {
                Debug.Log("waiting for horde to trigger, or something is wrong");
            }

            //trigger attack
            if (!isTerrorising && timeBeforeNextEvent <= 0)
            {
                isHunting = true;
            }
        }
       
        
    }
}
