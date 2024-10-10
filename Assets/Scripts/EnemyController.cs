using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public int health = 3;
    public int damageAmount;
    

    public GameObject explosion;

    public float playerRange = 10f;

    public Rigidbody2D rb;
    public float moveSpeed;

    public bool hasGun;
    public bool shouldShoot;
    public float fireRate = .5f;
    public float WithinRange = 1f;
    public float shotCounter;
    public float delayTime = 2f;
    public float delay = 2f;
    public GameObject bullet;
    public GameObject Player;
    public Transform FirePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, PlayerController.instance.transform.position) < playerRange)
        {
            Vector3 playerDirection = PlayerController.instance.transform.position - transform.position;

            rb.linearVelocity = playerDirection.normalized * moveSpeed;


            if (hasGun)
            {
                if (shouldShoot)
                {
                    shotCounter -= Time.deltaTime;
                    if (shotCounter <= 0)
                    {
                        Instantiate(bullet, FirePoint.position, FirePoint.rotation);
                        shotCounter = fireRate;
                    }
                }
            }

        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
        //for enemy with no guns only hand combat
        if (!hasGun)
        {
            if (IsClosetoTarget())
            {
              
                    MeleeDamage();
             
                
                
            }
        }
    }

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);

            Instantiate(explosion, transform.position, transform.rotation);

            AudioController.instance.PlayEnemyDeath();
        }
        else
        {
            AudioController.instance.PlayEnemyShot();
        }
    }

    public bool IsClosetoTarget()
    {
        bool result = false;
        if (GetDistanceTo(Player) < WithinRange)
        {
            result = true;
        }
        return result;
        // return (GetDistanceTo(currentTarget) > withinRange)
    }

    public float GetDistanceTo(GameObject Other)
    {
        Vector3 dVector = Other.transform.position - gameObject.transform.position;
        return dVector.magnitude;
    }
    public void MeleeDamage() 
    {
        Debug.Log("Close");

        delay -= Time.deltaTime;
        if (delay <= 0)
        {
            PlayerController.instance.TakeDamage(damageAmount);
            delay = delayTime;
        }
        
    }
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {

        //for enemy with no guns only hand combat
        if (!hasGun)
        {
            if (IsClosetoTarget())
            {
                PlayerController Pc = other.gameObject.GetComponentInParent<PlayerController>();
                if (Pc)
                {
                    PlayerController.instance.TakeDamage(damageAmount);



                }
            }
        }
    }
    */
}
