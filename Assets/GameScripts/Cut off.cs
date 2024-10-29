using UnityEngine;

public class Cutoff : MonoBehaviour
{
    public GameObject bodyPart;
    public bool IsCut = false;
    public bool Head = false;
    public bool body = false;
    public bool Rleg = false;
    public bool Lleg = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (IsCut == true && Head == true || body == true)
        {
            Enemy.Instance.Died();
        }
        else if (IsCut == true)
        {
            Destroy(gameObject);
            Instantiate(bodyPart, transform.position, transform.rotation);
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
