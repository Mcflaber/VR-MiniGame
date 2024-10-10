using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float currentHealth;
 
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
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            
            currentHealth = 0;
        }
        //HealthField.text = currentHealth.ToString() + "%";

        //AudioController.instance.PlayPlayerHurt();
    }
}
