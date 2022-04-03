using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;

    public float gravity = -9.81f;
    public float jumpHeight=3f;
    

    public Transform grouncheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
    
    private void Update()
    {
        isGrounded = Physics.CheckSphere(grouncheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = 1;
        Vector3 move = transform.right * horizontal;
        controller.Move(move*speed*Time.deltaTime);

        if (Input.GetMouseButton(0) && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y+=gravity*Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }
}
