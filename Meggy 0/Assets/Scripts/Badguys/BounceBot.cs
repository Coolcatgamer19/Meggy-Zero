using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceBot : MonoBehaviour
{

    public float Speed;
    public float BounceForce;
    public float moveDirection;
    public Rigidbody2D body;
    public BoxCollider2D Boxy;
    public bool Bounced;
    public GameObject LeftCol;
    public GameObject RightCol;

    public float MaxSpeed;
    public float curentSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Bounced = false;
        moveDirection = 1;
        MaxSpeed = Speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
            body.velocity = (Vector2.left * moveDirection * Speed);
        

        

        if (Bounced = true)
        {
            body.AddForce(Vector2.up * BounceForce);
            Bounced = false;
        }
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {  
        moveDirection = -1;      
        Bounced = true;
    }



}
