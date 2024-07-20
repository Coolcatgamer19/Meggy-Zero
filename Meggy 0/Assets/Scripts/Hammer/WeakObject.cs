using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeakObject : MonoBehaviour
{

    public GameObject CurrentObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (tag == "Hammer")
        {
            Destroy(CurrentObject);
        }
    }
}
