using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField]
    private float SpeedRotate = 1;
    void Update()
    {
        transform.Rotate(new Vector3(0, SpeedRotate, 0) * Time.deltaTime);
    }
}
