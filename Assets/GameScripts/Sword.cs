using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;
using UnityEngine.XR;

public class Sword : MonoBehaviour
{
    public static Sword Instance;
    public int damageAmount;
    public bool isEnemySword;
    public float buffer = 1f;



    public InputActionReference blocking;
    public Quaternion rotation;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemySword == false)
        {
            rotation = blocking.action.ReadValue<Quaternion>();
        }

        




    }
    private void OnTriggerEnter(Collider other)
    {
        if (isEnemySword)
        {
            Player Pc = other.gameObject.GetComponentInParent<Player>();
            if (Pc)
            {

                
                if (rotation.y < 200)
                {
                    buffer -= Time.deltaTime;
                    if (buffer < 0)
                    {
                        Player.Instance.TakeDamage(damageAmount);
                        buffer = 1;
                    }
                }
                else
                {
                    Debug.Log("blocked");
                }






            }
        }

    }
}
