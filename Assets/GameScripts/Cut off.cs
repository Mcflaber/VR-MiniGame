using UnityEngine;

public class Cutoff : MonoBehaviour
{
    public GameObject bodyPart;
    public bool IsCut = false;
    public GameObject head;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsCut == true)
        {
            Destroy(gameObject);
            Instantiate(bodyPart, transform.position, transform.rotation);
        }
        if(head == null)
        {
            IsCut = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Sword sword = other.GetComponent<Sword>();
        if (sword)
        {
            
            IsCut = true;


        }
    }
    
}
