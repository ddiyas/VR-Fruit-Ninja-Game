using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyApple : MonoBehaviour
{
    public GameObject appleHalf;
    //public GameObject explosionn;

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
        //Instantiate(explosionn, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameObject half1 = Instantiate(appleHalf, transform.position, Quaternion.identity);
        GameObject half2 = Instantiate(appleHalf, transform.position, Quaternion.identity);

        GameObject score = GameObject.Find("EventSystem");
        score.GetComponent<Score>().addScore();

        half1.GetComponent<Rigidbody>().AddForce(new Vector3(2, 0, 0), ForceMode.Impulse);
        half2.GetComponent<Rigidbody>().AddForce(new Vector3(-2, 0, 0), ForceMode.Impulse);
    }
}
