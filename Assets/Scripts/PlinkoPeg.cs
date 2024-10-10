using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoPeg : MonoBehaviour
{
    public Material normalMaterial;
    public Material hitMaterial;
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        mr.material = hitMaterial;
    }
    private void OnCollisionExit(Collision collision)
    {
        mr.material = normalMaterial;

    }
}
