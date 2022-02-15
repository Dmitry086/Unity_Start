using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot_Ball : MonoBehaviour
{
    [SerializeField] float BallSpeed;
    [SerializeField] GameObject BallPrefab;

    void BallShoot()
    {
        GameObject Ball = Instantiate(BallPrefab, transform.position, transform.rotation);
        Rigidbody rb = Ball.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * BallSpeed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BallShoot();
        }
        
    }
}
