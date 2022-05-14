using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public FixedButton stopButton;
    public FixedButton screen;

    public CharacterController controller;
    public float speed = 6f;

    public float gravity = -9.81f;
    public float jumpHeight = 3f;


    public Transform grouncheck;
    public float groundDistance = 0.1f;
    public LayerMask groundMask;

    public Transform frontcheck;

    Vector3 velocity;
    bool isGrounded;
    bool isBumped;

    private Animator animator;
    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    private void Update()
    {
        isGrounded = Physics.CheckSphere(grouncheck.position, groundDistance, groundMask);
        isBumped = Physics.CheckSphere(frontcheck.position, 0.4f, groundMask);


        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float horizontal = 1;
        Vector3 move = transform.right * horizontal;


        if (screen.Pressed && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (isBumped || stopButton.Pressed)
        {
            move = transform.right * 0;
        }
        else
        {
            speed += 0.00001f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        controller.Move(move * speed * Time.deltaTime);
        animator.SetFloat("Speed", move.x * speed / 6);

        animator.SetBool("Jump", !isGrounded);
    }
}
