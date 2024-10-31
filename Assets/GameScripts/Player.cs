using TMPro;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float currentHealth;


    public InputActionReference blocking;
    public Quaternion rotation;

    public bool isBlocking;

    public void Awake()
    {
        Instance = this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        rotation = blocking.action.ReadValue<Quaternion>();

        if (rotation.z < 200.00)
        {
            isBlocking = false;
        }
        else
        {
            isBlocking = true;
        }
    }

    public void TakeDamage(int damageAmount)
    {
            currentHealth -= damageAmount;

        
        if(isBlocking == true)
        {
            damageAmount = 0;
        }
        else
        {
            damageAmount = 10;
        }
        if (currentHealth <= 0)
        {

            currentHealth = 0;
            SceneManager.LoadScene("Death");
            

        }

    }
}
