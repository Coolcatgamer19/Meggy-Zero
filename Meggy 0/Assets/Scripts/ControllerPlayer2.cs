using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer2 : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public float Health = 100f;
    public Rigidbody2D Body;
    public Animator animator;
    public CharacterController2D controller;
    public bool Dead;
    public LayerMask DeathLayer;
    public float horizontalMove;
    public bool Jumping = false;
    public bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100f;  
    }

    // Update is called once per frame
    void Update()
    {
       
        horizontalMove = Input.GetAxisRaw("Horizontal2") * Speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButton("Jump2"))
        {
            Jumping = true;
            animator.SetBool("Jumping", true);
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {

        
            Health = -10;
            Dead = true;
        animator.SetBool("Dead", true);
        Dead = true;
        animator.SetBool("Jumping", false);

    }




    public void Onlanding()
    {
        animator.SetBool("Jumping", false);
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, Jumping);
        Jumping = false;
    }

}
