using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text Scoreboard;
    public GameObject ball;


    //Players Score
    public int Wall1_Score = 0;
    public int Wall2_Score = 0;

    void Start()
    {
        ball = GameObject.Find("Ball");
    }

    
    void Update()
    {

        //condition regarding scoring   
        if (ball.transform.position.x >= 8f)
        {
            Wall1_Score++;
        }

        if(ball.transform.position.x <= -8f)
        {
            Wall2_Score++;
        }


        //Show Score
        Scoreboard.text = Wall1_Score.ToString() + " : " + Wall2_Score.ToString();

        print(Wall1_Score + " : " + Wall1_Score);
    }
}
