using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlinkoSlot : MonoBehaviour
{
    public int slotScore = 100;
    public float destroyDelay = 5f;
    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer mr = gameObject.GetComponent<MeshRenderer>();
        mr.enabled = false;

        //gameObject.SetActive = (false);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlinkoDisk pd = other.gameObject.GetComponentInParent<PlinkoDisk>();
        if (pd)
        {
            Destroy(pd.gameObject, destroyDelay);

            Debug.Log("Scored " + slotScore + "Points");

            PlinkoManager.instance.AddScore(slotScore);

        }




    }

}
