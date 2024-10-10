using UnityEngine;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public Rigidbody2D rb;
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
        Enemy bad = other.gameObject.GetComponentInParent<Enemy>();
        Player Pc = other.gameObject.GetComponentInParent<Player>();
        if (Pc)
        {
            Player.Instance.TakeDamage(damageAmount);

            Destroy(gameObject);

        }
        if(bad)
        {

        }
    }
}
