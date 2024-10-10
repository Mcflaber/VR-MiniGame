using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SoccerNet : MonoBehaviour
{

    public int teamNumber = 1;
    public int score = 1;


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "entered net");

        SoccerBall sb = other.gameObject.GetComponentInParent<SoccerBall>();

        if (sb)
        {
            Debug.Log("Ball is in the Net");
            sb.Reset();
            SoccerManager.refrence.AddScore(teamNumber, 1);
        }




    }


}
