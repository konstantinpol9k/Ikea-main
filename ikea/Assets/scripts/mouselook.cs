using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensivity = 320f;
    float xRotation = 0f;
    public bool ButtonI;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.I))
            {
                ButtonI = !ButtonI;
                if (ButtonI)
                {
                mouseSensivity = 0f;
                }
                else
                {
                mouseSensivity = 320f;
                }
            }
            float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime; 
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
