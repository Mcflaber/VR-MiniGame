using UnityEngine;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public bool isplayerSword;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (isplayerSword)
        {
            Enemy bad = other.gameObject.GetComponentInParent<Enemy>();
            if (bad)
            {
                Enemy.Instance.TakeDamage(damageAmount);
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
