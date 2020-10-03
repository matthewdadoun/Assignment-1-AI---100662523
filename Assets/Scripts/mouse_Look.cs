using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse_Look : MonoBehaviour
{
    public float mouseSensitivity = 10f;

    public Transform playerBody;

    float xRotation = 0f;
//Locks cursor to center of screen
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame

        //Mouse controls
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}