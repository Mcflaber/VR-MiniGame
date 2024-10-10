using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LockCurser();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            UnLockCurser();
        }
        if (Input.GetMouseButton(0))
        {
            LockCurser();

        }
    }
    private void LockCurser()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    private void UnLockCurser()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
