using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float WalkSpeed;
    public float RunSpeed;
    public float JumpForce;

    public CharacterController2D controller;

    public float horizontalMove;
    public bool Jumping = false;
    public bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * WalkSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            Jumping = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, Jumping);
        Jumping = false;
    }

}
