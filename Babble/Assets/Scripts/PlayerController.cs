using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float walkSpeed;
    public float sprintSpeed;
    public bool isStunning;
    public bool isSprinting;
    public float mouseSensitivity;
    public float currentSpeed;
  
    void Update()
    {
        CheckIfSprinting();
        if (isSprinting)
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * mouseSensitivity, 0)));
        rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * currentSpeed) + (transform.right * Input.GetAxis("Horizontal") * currentSpeed));
      
    }

    public void CheckIfSprinting()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else
        {
            isSprinting = false;
        }
    }

    
}
