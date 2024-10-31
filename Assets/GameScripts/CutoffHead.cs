using UnityEngine;

public class CutoffHead : MonoBehaviour
{
    public GameObject bodyPart;
    public GameObject bodyPart2;
    public GameObject bodyPart3;
    public GameObject bodyPart4;
    public GameObject bodyPart5;
    public GameObject bodyPart6;
    public bool IsCut = false;
    public GameObject Enemy;
    public int Hp;
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
            Instantiate(bodyPart2, transform.position, transform.rotation);
            Instantiate(bodyPart3, transform.position, transform.rotation);
            Instantiate(bodyPart4, transform.position, transform.rotation);
            Instantiate(bodyPart5, transform.position, transform.rotation);
            Instantiate(bodyPart6, transform.position, transform.rotation);
            Destroy(Enemy);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Sword sword = other.GetComponent<Sword>();
        if (sword)
        {
            Hp--;
            if(Hp <= 0)
            {
                IsCut = true;
            }
            


        }
    }
    
}
