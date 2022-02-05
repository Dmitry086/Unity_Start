using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player;

    [SerializeField] private float SpeedMouse = 200;

    private float mouseX;
    private float mouseY;
    private float xRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * SpeedMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * SpeedMouse * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        Player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //Player.Rotate(mouseX * new Vector3(0, 1, 0));
        //transform.Rotate(xRotation * new Vector3(1, 0, 0));
    }
}
