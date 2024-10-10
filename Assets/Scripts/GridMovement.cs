using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMovement : MonoBehaviour
{
    public int gridSize = 1;

    bool up;

    bool left;

    bool down;

    bool right; 

    

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

         up = Input.GetKeyDown(KeyCode.I);

        left = Input.GetKeyDown(KeyCode.J);

        down = Input.GetKeyDown(KeyCode.K);

        right = Input.GetKeyDown(KeyCode.L);



        if (up)
        {
            location.z += gridSize;
            gameObject.transform.forward = Vector3.forward;
        }

        if (left)
        {
            location.x -= gridSize;
            gameObject.transform.forward = -Vector3.right;
        }

        if (down)
        {
            location.z -= gridSize;
            gameObject.transform.forward = -Vector3.forward;
        }

        if (right)
        {
            location.x += gridSize;
            gameObject.transform.forward = Vector3.right;
        }


        transf.position = location;

    }
}
