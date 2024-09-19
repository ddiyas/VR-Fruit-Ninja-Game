using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKiwi : MonoBehaviour
{
    public GameObject kiwiHalf;

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
        Debug.Log("destroying");
        Destroy(gameObject);
        GameObject half1 = Instantiate(kiwiHalf, transform.position, Quaternion.identity);
        GameObject half2 = Instantiate(kiwiHalf, transform.position, Quaternion.identity);

        GameObject score = GameObject.Find("EventSystem");
        score.GetComponent<Score>().addScore();

        half1.GetComponent<Rigidbody>().AddForce(new Vector3(0, 50, 0), ForceMode.Impulse);
        half2.GetComponent<Rigidbody>().AddForce(new Vector3(-2, 50, 0), ForceMode.Impulse);
    }
}
