using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollTrigger : MonoBehaviour
{
    public SpriteRenderer doll;
    public Sprite newDollSprite;
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("player");
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                doll.sprite= newDollSprite;
                Debug.Log("player in trigger zone");
            }
        }
    }
}
