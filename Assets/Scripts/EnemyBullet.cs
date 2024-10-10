using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int damageAmount;

    public float bulletSpeed = 5f;

    public Rigidbody2D rb;

    private Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {
        direction = PlayerController.instance.transform.position - transform.position;
        direction.Normalize();
        direction = direction * bulletSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = direction * bulletSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController Pc = other.gameObject.GetComponentInParent<PlayerController>();
        if (Pc)
        {
            PlayerController.instance.TakeDamage(damageAmount);
                
            Destroy(gameObject);
            
        }
    }
}
