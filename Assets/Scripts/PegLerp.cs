using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegLerp : MonoBehaviour
{
    public Color hit;
    public Color normal;
    public float lerpTime = 5f;
    float lerpTimer = 0;
 Material mat;

    bool isInLerp = false;

    void Start()
    {
        //mr = gameObject
        mat = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInLerp)
        {
            lerpTimer -= Time.deltaTime;
            float percentage = lerpTimer / lerpTimer;
            if (percentage <= 0)
            {
                percentage = 0;
                isInLerp = false;
            }

            Color newColor = Color.black;
            newColor.r = Mathf.Lerp(normal.r, hit.r, percentage);
            newColor.g = Mathf.Lerp(normal.g, hit.g, percentage);
            newColor.b = Mathf.Lerp(normal.b, hit.b, percentage);
            newColor.a = Mathf.Lerp(normal.a, hit.a, percentage);
            mat.color = newColor;

            //mr.material = mat;



        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isInLerp = true;
        lerpTimer = lerpTime;
    }
}
