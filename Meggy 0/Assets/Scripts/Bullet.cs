using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{


    public Rigidbody2D Body;
    public float bulletSpeed;
    public float BulletDamage;

    public GameObject Bulet;


    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {

        Body.AddForce(transform.forward * bulletSpeed);

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject.Destroy(Bulet);
    }


}
