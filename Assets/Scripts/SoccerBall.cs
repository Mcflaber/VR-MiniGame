using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerBall : MonoBehaviour
{
    Vector3 startLocation;
    Quaternion startRotation;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        startLocation = gameObject.transform.position;
        startRotation = gameObject.transform.rotation;
    }

   
    public void Reset()
    {
        gameObject.transform.position = startLocation;
        gameObject.transform.rotation = startRotation;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
