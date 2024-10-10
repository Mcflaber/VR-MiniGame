using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class shotgun : MonoBehaviour
{




    public Camera viewCam;

    public GameObject bulletImpact;
  


    public Animator gunAnim;
    public Animator Anim;

   
 
    public int currentAmmo;
 

    private bool hasDied = false;

    public TextMeshProUGUI  AmmoField;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
    }
    public void UpdateAmmoUI()
    {
        AmmoField.text = currentAmmo.ToString();
    }
}
