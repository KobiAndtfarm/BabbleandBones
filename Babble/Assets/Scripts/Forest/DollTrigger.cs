using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollTrigger : MonoBehaviour
{
    public Sprite doll;
    public Sprite newDollSprite;
    public void OnTriggerStay(Collider other)
    {
        if (gameObject.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                doll = newDollSprite;
            }
        }
    }
}
