using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEvent : MonoBehaviour
{
    public UnityEvent OnTrigger;
 
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OnTrigger.Invoke();
        }
    }
}
