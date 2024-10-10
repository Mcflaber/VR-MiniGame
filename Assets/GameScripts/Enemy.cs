using System;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy Instance;
    public delegate void ThinkFuction();
    public float WithinRange = 1f;
    public float moveSpeed;
    public GameObject CurrentTarget;
    public Boolean HasDynamicDirection = false;

    Rigidbody rb;
    ThinkFuction think;

    Vector3 moveDirection = Vector3.zero;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        think = UpdateChase;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateChase();
    }


    public float GetDistanceTo(GameObject Other)
    {
        Vector3 dVector = Other.transform.position - gameObject.transform.position;
        return dVector.magnitude;
    }
    public bool IsClosetoTarget()
    {
        bool result = false;
        if (GetDistanceTo(CurrentTarget) < WithinRange)
        {
            result = true;
        }
        return result;
        // return (GetDistanceTo(currentTarget) > withinRange)
    }

    public void UpdateMoveDirection()
    {
        Vector3 vectorB = CurrentTarget.transform.position;
        Vector3 vectorA = gameObject.transform.position;
        Vector3 deltaVector = vectorB - vectorA;
        moveDirection = deltaVector.normalized;
        gameObject.transform.forward = moveDirection;


    }



    void UpdateChase()
    {
        if (HasDynamicDirection)
        {
            UpdateMoveDirection();
        }

        Vector3 location = gameObject.transform.position;
        location += moveDirection * moveSpeed * Time.deltaTime;
        gameObject.transform.position = location;

        if (IsClosetoTarget())
        {  
            UpdateMoveDirection();
            Attack();
        }
    }
    void Block()
    {

    }
    void Attack()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }


}

