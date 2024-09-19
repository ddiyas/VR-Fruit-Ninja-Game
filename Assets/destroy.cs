using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class destroy : MonoBehaviour
{
    public GameObject strawberryHalf;
   // public GameObject explosion;
    public TextElement text;
    int score = 0;

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
       // Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        GameObject half1 = Instantiate(strawberryHalf, transform.position, Quaternion.identity);
        GameObject half2 = Instantiate(strawberryHalf, transform.position, Quaternion.identity);

        GameObject score = GameObject.Find("EventSystem");
        score.GetComponent<Score>().addScore();

        half1.GetComponent<Rigidbody>().AddForce(new Vector3(2, 0, 0), ForceMode.Impulse);
        half2.GetComponent<Rigidbody>().AddForce(new Vector3(-2, 0, 0), ForceMode.Impulse);
    }
}
