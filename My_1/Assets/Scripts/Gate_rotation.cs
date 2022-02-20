using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_rotation : MonoBehaviour
{
    [SerializeField] float GateOpenAngle;
    [SerializeField] float GateOpenSpeed;
    float GateCloseAngle = 0;
    [SerializeField] bool isGateOpen = false;
    [SerializeField] public int enemyCount;

    void GateOpenClose()
    {
        if (enemyCount == 0)
        {
            transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, GateOpenAngle), GateOpenSpeed * Time.deltaTime);
        }
        else transform.localRotation = Quaternion.Slerp(transform.localRotation, Quaternion.Euler(transform.localRotation.x, transform.localRotation.y, GateCloseAngle), GateOpenSpeed * Time.deltaTime);
    }


    void Update()
    {
        GateOpenClose();
    }
}
