using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public float Speed;
    public float runSpeed;
    public float walkSpeed;

    public float JumpForce;
    public float Health = 100f;

    public Rigidbody2D Body;
    public Animator animator;
    public CharacterController2D controller;

    public float ScoreFloat;

    public int idleA;

    public Text Score;

    public float horizontalMove;
    public bool Jumping = false;
    public bool crouch = false;
    public float timer = 400.0f;


    public float togle;
    public int EscapeTogle;

    public GameObject pauseMenu;


    public bool Gun;
    public bool Hammer;
    public bool Cloack;



    public GameObject BulletSpawn;
    public GameObject Bullet;
    public float BulletSpeed;

    public int ShootDirection;



    // Start is called before the first frame update
    void Start()
    {
        Health = 100f;

        Speed = walkSpeed;
    }

    // Update is called once per frame
    void Update()

    {




        //Controlls


        if (Cloack == true)
        {
            Hammer = false;
            Gun = false;
            animator.SetBool("Hood", true);
            if (Input.GetKey(KeyCode.Mouse0))
            {
                animator.SetBool("HoodDown", true);
            }
            else
            {
                animator.SetBool("HoodDown", false);
            }
        }

        if (Hammer == true)
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
               
                animator.SetBool("HammerSwing", true);
                horizontalMove = 0.0f;
                togle = 10;
                Speed = 0;
                
            }
            else
            {
                animator.SetBool("HammerSwing", false);
                togle = 0;
                Speed = walkSpeed;
                horizontalMove = horizontalMove;
            }
        }
        





        if (Gun == true)
        {
            Hammer = false;
            Cloack = false;
            if (Input.GetKey(KeyCode.Mouse0))
            {
                togle = 0;
                GameObject newbullet = Instantiate(Bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
                newbullet.GetComponent<Rigidbody2D>().velocity = transform.right * ShootDirection * BulletSpeed;
                
            }
        }
       






        if (Input.GetKey(KeyCode.A))
        {
            ShootDirection = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            ShootDirection = 1;
        }



        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Gun = true;
            animator.SetBool("Gun", true);
            animator.SetBool("Hammer", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Hammer = true;
            animator.SetBool("Hammer", true);
            animator.SetBool("Gun", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Cloack = true;
            animator.SetBool("Hammer", false);
            animator.SetBool("Gun", false);
            animator.SetBool("Hood", true);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            togle = 1 -togle;
        }

        if (togle == 0)
        {
            Speed = runSpeed;
            animator.SetBool("Sprinting", false);
        }
        if (togle == 1)
        {
            animator.SetBool("Sprinting", true);
            Speed = walkSpeed;
        }

       

        if (Mathf.Abs(horizontalMove) == 0.0f)
        {
            togle = 0;
        }


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
            idleA = Random.RandomRange(1, 3);
        }

        //ANAMTIONS


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



        Score.text = "Score:" + ScoreFloat;

    //Control maths

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

    


    private void OnTriggerEnter2D(Collider2D collision)
    {

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
