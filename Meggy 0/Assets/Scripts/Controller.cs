using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Speed;
    public float JumpForce;
    public float Health = 100f;

    public Rigidbody2D Body;
    public Animator animator;
    public CharacterController2D controller;

    public bool Dead;
    public float DeathMoveUp;


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
        horizontalMove = Input.GetAxisRaw("Horizontal") * Speed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButton("Jump"))
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
        horizontalMove = 0;
        Body.velocity = new Vector3(0, 0, 0);
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
