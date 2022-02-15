using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gates_up_down : MonoBehaviour
{
    [SerializeField] Vector3 GateUp;
    Vector3 GateDown;
    [SerializeField] float GateSpeed;
    [SerializeField] bool isGateOpen;
    [SerializeField] GameObject Gate;
    [SerializeField] bool GateGo;

    void Start()
    {
        GateDown = transform.localPosition;
    }


    void GateUpDown()
    {
        if (isGateOpen == true)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, GateUp, GateSpeed * Time.deltaTime);

        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, GateDown, GateSpeed * Time.deltaTime);
        }
    }

    void Update()
    {
        GateGo = Gate.GetComponent<control_gates_up_down>().isControlDown;
        if (GateGo == true) isGateOpen = true;
        else isGateOpen = false;

        GateUpDown();
    }
}
