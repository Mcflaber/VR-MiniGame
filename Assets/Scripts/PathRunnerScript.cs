using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class PathRunnerScript : MonoBehaviour
{
    public GameObject TargetA;
    public GameObject TargetB;
    public bool IsMovingToA = true;
    public float moveSpeed = 5f;
    public float WithinRange = .75f;
    public Boolean HasDynamicDirection = false;
    Vector3 moveDirection = Vector3.zero;
    GameObject CurrentTarget;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTarget = TargetA;
        IsMovingToA = true;
        UpdateMoveDirection();
    }

    // Update is called once per frame
    void Update()
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
            NextTarget();
            UpdateMoveDirection();
        }


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

    void NextTarget()
    {
        if (IsMovingToA)
        {
            CurrentTarget = TargetB;
            IsMovingToA = false;
        }
        else
        {
            CurrentTarget = TargetA;
            IsMovingToA = true;
        }
        UpdateMoveDirection();
    }

    public void UpdateMoveDirection()
    {
        Vector3 vectorB = CurrentTarget.transform.position;
        Vector3 vectorA = gameObject.transform.position;
        Vector3 deltaVector = vectorB - vectorA;
        moveDirection = deltaVector.normalized;
        gameObject.transform.forward = moveDirection;


        // could have done Vector3 dVecotr = CurrentTarget.transform.position - gameObjcet.transform.posision
        //MoveDirection = deltaVector.normalized;
        //gameObject.transform.forward = moveDirection;

        //way #3 moveDirection = (currentTarget.position - gameObject.transform
    }

}
