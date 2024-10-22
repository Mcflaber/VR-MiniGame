using UnityEngine;
using UnityEngine.InputSystem;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public bool isplayerSword;

    public float rotation;
 
    public float wait;

    InputAction ThisAction;
    public InputActionReference SomeAction;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ThisAction = InputSystem.actions.FindAction("XRI Left/rotation");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = ThisAction.ReadValue<Vector3>();

        


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
