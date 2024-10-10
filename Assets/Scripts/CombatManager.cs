using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public TextMeshProUGUI tankDeathField;
    public TextMeshProUGUI soldierDeathField;
    public static CombatManager refrence;
    int soldier = 0;
    int tank = 0;
    public int Score = 0;


    public void Awake()
    {

        refrence = this;
    }





    // Start is called before the first frame update
    void Start()
    {
        soldier = 0;
        tank = 0;
    }

    // Update is called once per frame
    void Update()
    {


        tankDeathField.text = tank + "";
        soldierDeathField.text = soldier + "";
    }
    public void AddScore(int team, int newscore)
    {
        if (team == 1)
        {
            tank += newscore; return;
        }

        if (team == 2)
        {
            soldier += newscore; return;
        }

        if (team == 0)
        {
            tank += newscore; return;
        }



    }
}

