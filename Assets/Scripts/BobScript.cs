using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BobScript : MonoBehaviour
{
    Transform transf;

    public int bobSpeed = 1;
    public int bobHieght = 1;

     


    // Start is called before the first frame update
    void Start()
    {

        transf = gameObject.transform;
    }


    // Update is called once per frame
    void Update()
    {
        Vector3 location = transf.position;

        if (location.y <= bobHieght)
        {
            location.y += bobHieght * bobSpeed;

        }
        


        transf.position = location;
    }
}
