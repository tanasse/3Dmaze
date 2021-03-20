using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreScript : MonoBehaviour
{
    int Score;
    public Text ScoreText;

    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "Score : " + Score.ToString() + "/240"; 
    }
     public void Addpoint(int point)
    {
        Score += point;
    }
}
