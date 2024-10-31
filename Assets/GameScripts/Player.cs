using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float currentHealth;
   
    public bool isBlocking;

   
    public quaternion pos;
    public TextMeshProUGUI HealthField;
    public void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentHealth = 100;
        HealthField.text = currentHealth.ToString() + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    public void TakeDamage(int damageAmount)
    {
            currentHealth -= damageAmount;

        HealthField.text = currentHealth.ToString() + "%";

        if (currentHealth <= 0)
        {

            currentHealth = 0;
            SceneManager.LoadScene("Death");
            

        }

    }
}
