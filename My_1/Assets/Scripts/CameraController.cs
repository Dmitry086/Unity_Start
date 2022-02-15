using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform Weapon;

    [SerializeField] private float SpeedMouse = 200;

    private float mouseX;
    private float mouseY;
    private float xRotationP;
    private float xRotationW;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * SpeedMouse * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * SpeedMouse * Time.deltaTime;

        xRotationP -= mouseY;
        xRotationP = Mathf.Clamp(xRotationP, -80f, 80f);
        //xRotationW = mouseY;
        //xRotationW = Mathf.Clamp(xRotationW, -30f, 30f);

        Player.Rotate(Vector3.up * mouseX);
        Weapon.Rotate(Vector3.left  * mouseY);
        
        transform.localRotation = Quaternion.Euler(xRotationP, 0f, 0f);
        //transform.localRotation = Quaternion.Euler(xRotationW, 0f, 0f);




        //Player.Rotate(mouseX * new Vector3(0, 1, 0));
        //transform.Rotate(xRotation * new Vector3(1, 0, 0));
    }
}
