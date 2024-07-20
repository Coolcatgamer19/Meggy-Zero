using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leafSpawner : MonoBehaviour
{

    public GameObject MinX;
    public GameObject MaxX;
    public float Minx;
    public float Maxx;

    public GameObject Leaf;

    // Start is called before the first frame update
    void Start()
    {
        Maxx = MaxX.transform.position.x;
        Minx = MinX.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        float Spawnpos = Random.RandomRange(Minx, Maxx);

        Instantiate<GameObject>(Leaf, Spawnpos, 00.f)


    }
}
