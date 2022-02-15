using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open_Door_1 : MonoBehaviour
{
    [SerializeField] float DoorOpenAngle;
    [SerializeField] float DoorOpenSpeed;
                     float DoorCloseAngle = 0;
    [SerializeField] bool isDoorOpen;
    [SerializeField] bool Player_at_Door;

    void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag == "Player") Player_at_Door = true;
    }
    void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag == "Player") Player_at_Door = false;
       
    }
    void DoorOpenClose()
    {
        if(isDoorOpen == true)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, DoorOpenAngle, transform.rotation.z), DoorOpenSpeed * Time.deltaTime);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(transform.rotation.x, DoorCloseAngle, transform.rotation.z), DoorOpenSpeed * Time.deltaTime);
        }
    }

    void OnGUI()

    {
        if (Player_at_Door)
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
        if (Input.GetKeyDown(KeyCode.F) & Player_at_Door)
        {
            if (isDoorOpen) isDoorOpen = false;
            else isDoorOpen = true; ;
        }
    }
}