using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{
    public GameObject bullet;
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Instantiate<GameObject>(bullet);
        }
    }
}