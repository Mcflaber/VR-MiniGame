using UnityEngine;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public bool isplayerSword;
    public bool isBlocking;
    public GameObject controller;
    public double rotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        rotation = gameObject.transform.rotation.y;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (isplayerSword)
        {
            Enemy bad = other.gameObject.GetComponentInParent<Enemy>();
            if (bad)
            {
                if (isBlocking && rotation <= 180f)
                {
                    Enemy.Instance.TakeDamage(damageAmount);
                }
            }
        }
        else
        {
            Player Pc = other.gameObject.GetComponentInParent<Player>();
            if (Pc)
            {
                Player.Instance.TakeDamage(damageAmount);



            }
        }

    }
}
