using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class spawn : MonoBehaviour
{
    private float x;
    private float z;
    private Random rand = new Random();
    public GameObject strawberry;
    public GameObject kiwi;
    public GameObject apple;
    public GameObject asteroid;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 0, 1);
        InvokeRepeating("SpawnAsteroid", 0, 7);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        x = rand.Next(-4, 5);
        z= rand.Next(-4, 5);

        int r = rand.Next(0, 3);
        
        if (r == 0)
        {
            GameObject b = Instantiate(strawberry, new Vector3(x, 20f, z), transform.rotation);
        } else if (r == 1)
        {
            GameObject b = Instantiate(kiwi, new Vector3(x, 20f, z), transform.rotation);
        } else
        {
            GameObject b = Instantiate(apple, new Vector3(x, 20f, z), transform.rotation);
        }
    }

    void SpawnAsteroid ()
    {
        x = rand.Next(-4, 5);
        z = rand.Next(-4, 5);

        GameObject a = Instantiate(asteroid, new Vector3(x, 30f, z), transform.rotation);
    }
}
