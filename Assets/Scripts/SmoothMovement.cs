using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothMovement : MonoBehaviour
{
    public float rotationRate = 180f;

    public float moveSpeed = 5f;

    bool keyup = false;

    bool keyleft = false;

    bool keydown = false;

    bool keyright = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetInput(); 


        if (keyup)
        {
            MovePlayer(1);
        }

        if (keyleft)
        {
            RotatePlayer(-1);
        }

        if (keydown)
        {
            MovePlayer(-1);
        }

        if (keyright)
        {
            RotatePlayer(1);
        }


    }
    void GetInput()
    {
        keyup = Input.GetKey(KeyCode.W);

        keyleft = Input.GetKey(KeyCode.A);

        keydown = Input.GetKey(KeyCode.S);

        keyright = Input.GetKey(KeyCode.D);
    }

    void MovePlayer(float value)
    {
        Vector3 location = gameObject.transform.position;
        location += gameObject.transform.forward * moveSpeed * Time.deltaTime * value;
        gameObject.transform.position = location;
    }

    void RotatePlayer(float value)
    {
        gameObject.transform.Rotate(Vector3.up * rotationRate * Time.deltaTime * value);
    }


}
