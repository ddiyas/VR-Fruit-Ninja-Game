using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAsteroid : MonoBehaviour
{
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);

        GameObject score = GameObject.Find("EventSystem");
        score.GetComponent<Score>().notAddScore();
    }
}
