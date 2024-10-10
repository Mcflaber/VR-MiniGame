using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoccerManager : MonoBehaviour
{
    public TextMeshProUGUI scoreField;
    public TextMeshProUGUI scoreField2;
    public static SoccerManager refrence;
    int scoreRed = 0;
    int scoreBlue = 0;



        public void Awake()
    {
     
        refrence = this; 
    }





    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreRed = 0;
        scoreBlue = 0;
    }

    // Update is called once per frame
    void Update()
    {


        scoreField.text = scoreRed + "";
        scoreField2.text = scoreBlue + "";
    }
    public void AddScore(int team, int newscore)
    {
        if (team == 1)
        {
            scoreRed += newscore; return;
        }

        if(team == 2)
        {
            scoreBlue += newscore; return;
        }




        
    }
}
