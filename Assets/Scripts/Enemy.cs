using UnityEngine;

public class Enemy : MonoBehaviour
{
    public delegate void ThinkFuction();
    ThinkFuction think;
    public GameObject Player;
    public float WithinRange = 1f;
    Rigidbody rb;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        think = Chase;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool IsClosetoTarget()
    {
        bool result = false;
        if (GetDistanceTo(Player) < WithinRange)
        {
            result = true;
        }
        return result;
        // return (GetDistanceTo(currentTarget) > withinRange)
    }

    public float GetDistanceTo(GameObject Other)
    {
        Vector3 dVector = Other.transform.position - gameObject.transform.position;
        return dVector.magnitude;
    }






    void Chase()
    {

    }
    void Block()
    {

    }
    void Attack()
    {

    }
}

