using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI scoreField;
    public static Manager Instance;
    public int currentScore = 0;
    public int displayScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (displayScore < currentScore)
        {
            displayScore++;
        }
        //scoreField.text = currentScore.ToString();
    }
    public void AddScore(int newScore)
    {
        currentScore += newScore;
    }
}
