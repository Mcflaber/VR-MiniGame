using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float bobbSpeed = 3f;
    public float bobbHeight = 20f;
    Vector3 startingLocation = Vector3.zero;
    bool isMovingUp = true;

    




    // Start is called before the first frame update
    void Start()
    {
        Transform Transform = gameObject.transform;
        startingLocation = Transform.position;
        isMovingUp = true;
    }

    // Update is called once per frame
    void Update()
    {
        //get location
        Vector3 location = gameObject.transform.position;

        if(isMovingUp)
        {
            location.y += bobbSpeed * Time.deltaTime;
        }
        else
        {
            location.y -= bobbSpeed * Time.deltaTime;
        }

        if (location.y > (startingLocation.y + bobbHeight))
        {
            isMovingUp = false;
            location.y = startingLocation.y;
        }

        if (location.y <= startingLocation.y)


        gameObject.transform.position = location;




    }
}
