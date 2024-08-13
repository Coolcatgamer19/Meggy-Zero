using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float Speed;
    public Rigidbody2D body;

    public float Diretion;
    public float MoveUpDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Diretion == 0)
        {
            MoveUpDown = -1;
        }
        if (Diretion == 1)
        {
            MoveUpDown = 1;
        }


        body.velocity = Vector2.up * MoveUpDown * Speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Diretion = 1 - Diretion;
    }




}
