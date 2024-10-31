using UnityEngine;

public class CutoffHead : MonoBehaviour
{
    public GameObject bodyPart;
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
