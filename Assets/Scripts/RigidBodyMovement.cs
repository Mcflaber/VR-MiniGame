using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    public float rotationRate = 180f;

    public float moveSpeed = 5f;

    public bool isplayer1 = true;

    bool keyup = false;

    bool keyleft = false;

    bool keydown = false;

    bool keyright = false;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        if (!rb)
        {
            Debug.Log("No Rigiedbody on" + gameObject.name);
        }


    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
        rb.linearVelocity = Vector3.zero;

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



        void GetInput()
        {
            if (isplayer1)
            {
                GetInputPlayer1();
            }
            else
            {
                GetInputPlayer2();
            }

        }
        void GetInputPlayer1()
        {
            keyup = Input.GetKey(KeyCode.W);

            keyleft = Input.GetKey(KeyCode.A);

            keydown = Input.GetKey(KeyCode.S);

            keyright = Input.GetKey(KeyCode.D);
        }
        void GetInputPlayer2()
        {
            keyup = Input.GetKey(KeyCode.I);

            keyleft = Input.GetKey(KeyCode.J);

            keydown = Input.GetKey(KeyCode.K);

            keyright = Input.GetKey(KeyCode.L);
        }
        void MovePlayer(float value)
        {

            rb.linearVelocity = gameObject.transform.forward * moveSpeed * value;

        }

        void RotatePlayer(float value)
        {
            gameObject.transform.Rotate(Vector3.up * rotationRate * Time.deltaTime * value);
        }


    }

}
