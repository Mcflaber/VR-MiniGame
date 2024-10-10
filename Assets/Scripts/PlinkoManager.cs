using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using TMPro;

public class PlinkoManager : MonoBehaviour
{
    public TextMeshProUGUI scoreField;
    public static PlinkoManager instance;
    public int currentScore = 0;
    public int displayScore = 0;

    public void Awake()
    {
        if (instance == null)
        {
            Debug.Log("Plink Manager had another instance it got overwritten ");
        }
        instance = this; 
    }



    // Start is called before the first frame update
    void Start()
{
    currentScore = 0;
    displayScore = 0;

}

    // Update is called once per frame
    void Update()
    {
    if (displayScore < currentScore)
    {
        displayScore++;
    }
    scoreField.text = currentScore.ToString();
    }
    public void AddScore(int newScore)
    {
    currentScore += newScore;
    }

}
