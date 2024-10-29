using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance;
    public float currentHealth;
   
    public bool isBlocking;

    InputAction ThisAction;
    public InputActionReference SomeAction;
    public quaternion pos;
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
        pos = ThisAction.ReadValue<quaternion>();
        
    }

    public void TakeDamage(int damageAmount)
    {
            currentHealth -= damageAmount;
       


        if (currentHealth <= 0)
        {

            currentHealth = 0;
        }

    }
}
