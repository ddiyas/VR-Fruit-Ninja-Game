using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public TMP_Text text;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score++;
        text.text = "Score: " + score;
    }

    public void notAddScore()
    {
        if (score > 5)
        {
            score -= 5;
        } else
        {
            score = 0;
        }
        text.text = "Score: " + score;
    }
}
