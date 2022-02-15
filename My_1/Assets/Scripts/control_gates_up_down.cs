using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control_gates_up_down : MonoBehaviour
{
    [SerializeField] float controlDown;
    [SerializeField] float controlSpeed;
    float controlUp = 0;
    public bool isControlDown;
    [SerializeField] bool Player_at_control;
    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player") Player_at_control = true;
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player") Player_at_control = false;

    }
    void DoorOpenClose()
    {
        if (isControlDown == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 45, controlDown), controlSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 45, controlUp), controlSpeed * Time.deltaTime);
        }
    }

    void OnGUI()

    {
        if (Player_at_control)
        {
            GUI.Label(new Rect(1200, 500, 500, 500), "Press <F>");
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        DoorOpenClose();
        if (Input.GetKeyDown(KeyCode.F) & Player_at_control)
        {
            if (isControlDown) isControlDown = false;
            else isControlDown = true; ;
        }
    }
}
