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

    public int idleA;

    public float horizontalMove;
    public bool Jumping = false;
    public bool crouch = false;
    public float timer = 400.0f;

    // Start is called before the first frame update
    void Start()
    {
        Health = 100f;

        

    }

    // Update is called once per frame
    void Update()
    {
        if (horizontalMove == 0.0f)
        {
            timer -= 1.0f;
        }
        else
        {
            timer = 400.0f;
        }

        if (timer == 0.0f)
        {
          idleA =  Random.RandomRange(1, 3);
        }

        if (idleA == 1)
        {
            animator.SetBool("Phone", false);
            animator.SetBool("Leggy", true);
            animator.SetBool("Switch", false);
        }
        else
        {
            animator.SetBool("Leggy", false);
        }
        
        
        if (idleA == 2)
        {
            animator.SetBool("Phone", true);
            animator.SetBool("Leggy", false);
            animator.SetBool("Switch", false);
        }
        else
        {
            animator.SetBool("Phone", false);
        }


        if (idleA == 3)
        {
           
            animator.SetBool("Phone", false);
            animator.SetBool("Leggy", false);
            animator.SetBool("Switch", true);
        }
        else
        {
            animator.SetBool("Switch", false);
        }

        if (timer == 0.0f)
        {
            timer = 400.0f;
        }

        if (horizontalMove > 0)
        {
            animator.SetBool("Phone", false);
            animator.SetBool("Leggy", false);
            animator.SetBool("Switch", false);
            idleA = 0;
        }







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
