using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public Rigidbody2D rb;

    public float moveSpeed = 5f;

    private Vector2 moveInput;
    private Vector2 mouseInput;

    public float mouseSensitivity = 1f;

    public Camera viewCam;

    public GameObject bulletImpact;
    public GameObject deadScreen;
    public List <GameObject> GunList;
    public GameObject CurrentGun;
    

    public Animator gunAnim;
    public Animator Anim;

    public int currentHealth;
    public int maxHealth = 100;
    public int currentAmmo;
    public int GunIndex;

    private bool hasDied = false;

    public TextMeshProUGUI HealthField, AmmoField;




    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        HealthField.text = currentHealth.ToString() + "%";



        AmmoField.text = currentAmmo.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasDied)
        {
            //player movement
            moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

            Vector3 moveHorizontal = transform.up * -moveInput.x;

            Vector3 moveVertical = transform.right * moveInput.y;

            rb.linearVelocity = (moveHorizontal + moveVertical) * moveSpeed;

            //player view controll
            mouseInput = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y")) * mouseSensitivity;

            transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z - mouseInput.x);

            viewCam.transform.localRotation = Quaternion.Euler(viewCam.transform.localRotation.eulerAngles + new Vector3(0f, mouseInput.y, 0f));

            //shooting
            /*
            if (Input.GetMouseButtonDown(0))
            {
               
                if (currentAmmo > 0)
                {
                    AudioController.instance.PlayGunShot();

                    Ray ray = viewCam.ViewportPointToRay(new Vector3(.5f, .5f, 0f));
                    RaycastHit hit;
                    if (Physics.Raycast(ray, out hit))
                    {
                        //Debug.Log("Im looking at " + hit.transform.name);
                        Instantiate(bulletImpact, hit.point, transform.rotation);

                        if (hit.transform.tag == "Enemy")
                        {
                            hit.transform.parent.GetComponent<EnemyController>().TakeDamage();
                        }
                        
                    }
                    else
                    {
                        Debug.Log("Im looking at nothing");
                    }
                    currentAmmo--;
                    gunAnim.SetTrigger("Shoot");
                    UpdateAmmoUI();
                }
            }
            */
            if (moveInput != Vector2.zero)
            { 
                Anim.SetBool("IsMoving", true); 
            
            
            }
            else
            {
                Anim.SetBool("IsMoving", false);
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                NextWeapon();
                
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                PrevWeapon();
                
            }
        }
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;

        if (currentHealth <= 0)
        {
            deadScreen.SetActive(true);
            hasDied = true;
            currentHealth = 0;
        }
        HealthField.text = currentHealth.ToString() + "%";

        AudioController.instance.PlayPlayerHurt();
    }

    public void AddHealth(int healthAmount)
    {
        currentHealth += healthAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        HealthField.text = currentHealth.ToString() + "%";
    }
    public void UpdateAmmoUI()
    {
        AmmoField.text = currentAmmo.ToString();
    }

    public void NextWeapon()
    {

        
        GunIndex++;



        CurrentGun.SetActive(false);

        if (GunIndex >= GunList.Count)
        {
            GunIndex = 0;
        }

        CurrentGun = GunList[GunIndex];



        CurrentGun.SetActive(true);


    }
    public void PrevWeapon()
    {
       

        GunIndex--;

        CurrentGun.SetActive(false);

        if (GunIndex < 0)
        {
            GunIndex = (GunList.Count - 1);
        }

        CurrentGun = GunList[GunIndex];

        CurrentGun.SetActive(true);

    }
}
