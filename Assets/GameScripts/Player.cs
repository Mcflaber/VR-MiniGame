using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float currentHealth;
    public float wait;
    public void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        currentHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damageAmount)
    {
        wait -= Time.deltaTime;
        if (wait == 0 )
        {
            currentHealth -= damageAmount;
        }
        

        if (currentHealth <= 0)
        {
            
            currentHealth = 0;
        }

    }
}
