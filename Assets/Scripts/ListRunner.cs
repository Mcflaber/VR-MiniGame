using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListRunner : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float WithinRange = .75f;
    public Boolean HasDynamicDirection = false;

    Vector3 moveDirection = Vector3.zero;
    GameObject CurrentTarget;
    public List<GameObject> pathList;
    int pathListIndex = 0;



    // Start is called before the first frame update
    void Start()
    {
        pathListIndex = 0;
        CurrentTarget = pathList[pathListIndex];
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
        pathListIndex++;

        if (pathListIndex >= pathList.Count)
        {
            pathListIndex = 0;
        }




        CurrentTarget = pathList[pathListIndex];
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

    public void UpdateFacing()
    {
        Vector3 faceing = moveDirection;
        faceing.y = 0;
        gameObject.transform.forward = faceing;
    }

}

