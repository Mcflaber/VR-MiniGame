using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.XR;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public bool isEnemySword;


 
 



    public InputActionReference blocking;
    public Quaternion rotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        rotation = blocking.action.ReadValue<Quaternion>();

      


    }
    private void OnTriggerEnter(Collider other)
    {
        if (isEnemySword)
        {
            Player Pc = other.gameObject.GetComponentInParent<Player>();
            if (Pc)
            {

                if (rotation.y > 200)
                {
                    Player.Instance.TakeDamage(damageAmount);
                }
                else
                {
                    Debug.Log("blocked");
                }
            }
        }

    }
}
