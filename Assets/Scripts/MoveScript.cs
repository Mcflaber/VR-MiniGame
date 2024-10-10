using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Vector3 moveDirection;

    Transform transf;

    // Start is called before the first frame update
    void Start()
    {
        transf = gameObject.transform;
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 location = transf.position;


        location += moveDirection * Time.deltaTime; 

        transf.position = location; 
    }
}
