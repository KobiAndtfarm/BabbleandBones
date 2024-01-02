using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public ClueCard CC;
    public HouseScriptableObject[] bedroom;
    public HouseScriptableObject[] livingRoom;
    public HouseScriptableObject[] kitchen;
    public Vector3 bedroomPos, livingPos, kitchenPos;
    public bool correctRoom;
    
    //house scriptable objects, with correct solution, turns on trigger at mini poi if match
    void Start()
    {
        CC = GetComponent<ClueCard>();
    }

    void OnEnable()
    {
        
        RandomiseBedroom();
        RandomiseKitchen();
        RandomiseLivingRoom();

    }

    void RandomiseBedroom()
    {
        foreach(HouseScriptableObject houseObj in bedroom)
        {
            int i = Random.Range(0, bedroom.Length + 1);
            
            bedroom[i].prefab = Resources.Load(bedroom[i].roomVariation) as GameObject;
            Instantiate(bedroom[i].prefab, bedroomPos, Quaternion.identity);

            if (CC.clueAnswer == "bedroom")
            {
                correctRoom = true;
            }
            if(correctRoom == true)
            {
                GameObject.Find(bedroom[i].miniPoi).SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }

    void RandomiseLivingRoom()
    {
        foreach (HouseScriptableObject houseObj in livingRoom)
        {
            int i = Random.Range(0, livingRoom.Length + 1);

            livingRoom[i].prefab = Resources.Load(livingRoom[i].roomVariation) as GameObject;
            Instantiate(livingRoom[i].prefab, livingPos, Quaternion.identity);

            if (CC.clueAnswer == "living")
            {
                correctRoom = true;
            }
            if (correctRoom == true)
            {
                GameObject.Find(livingRoom[i].miniPoi).SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }
    
    void RandomiseKitchen()
    {
        foreach (HouseScriptableObject houseObj in kitchen)
        {
            int i = Random.Range(0, kitchen.Length + 1);

            kitchen[i].prefab = Resources.Load(kitchen[i].roomVariation) as GameObject;
            Instantiate(kitchen[i].prefab, kitchenPos, Quaternion.identity);

            if (CC.clueAnswer == "kitchen")
            {
                correctRoom = true;
            }
            if (correctRoom == true)
            {
                GameObject.Find(kitchen[i].miniPoi).SetActive(true);
                this.gameObject.SetActive(false);
            }
        }
    }

    private void OnDisable()
    {
        correctRoom = false;

    }
}
