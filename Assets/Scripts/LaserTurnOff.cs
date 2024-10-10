using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserTurnOff : MonoBehaviour
{
    public GameObject Laser;
    public float lifeTime = .25f;
    float timer = 0f;

    public void TurnOn()
    {
        Laser.SetActive(true);
        timer = lifeTime;
    }
    public void TurnOff()
    {
        Laser.SetActive(false);
    }

    public void SetDistance(float distance)
    {
        Vector3 scale = Vector3.one;
        scale.z = distance;
        gameObject.transform.localScale = scale;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
            if(timer < 0)
            {
                TurnOff();
            }
        }
    }
}
