using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float walkSpeed =1;
    public float sprintSpeed;
    public bool isStunning;
    public bool isSprinting;
    public float currentSpeed;
    CharacterController characterController;
    public float velocity = 0;
    public float gravity = 9.8f;
    public Camera cam;
    public bool toolkit;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        CheckIfSprinting();
        CheckIfStunning();
        CheckToolKitStatus();
        if (isSprinting)
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = walkSpeed;
        }
        // player movement - forward, backward, left, right
        float horizontal = Input.GetAxis("Horizontal") * currentSpeed;
        float vertical = Input.GetAxis("Vertical") * currentSpeed;
        characterController.Move((cam.transform.right * horizontal + cam.transform.forward * vertical) * Time.deltaTime);

        // Gravity
        if (characterController.isGrounded)
        {
            velocity = 0;
        }
        else
        {
            velocity -= gravity * Time.deltaTime;
            characterController.Move(new Vector3(0, velocity, 0));
        }

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

    public void CheckIfStunning()
    {
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            isStunning = true;
            Debug.Log("stun key pressed");
        }
        else
        {
            isStunning = false;
            
        }
    }

    public void CheckToolKitStatus()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            toolkit = true;
            Debug.Log("toolkit opened");
        }
        else
        {
            Debug.Log("toolkit closed");
        }
    }
}
