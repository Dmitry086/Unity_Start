using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackingRotation : MonoBehaviour
{
    [SerializeField] Transform TargetObject;
    [SerializeField] Transform ОbserverObject;
    [SerializeField] float speed;
    [SerializeField] float distance;

    [SerializeField] float BulletSpeed;
    [SerializeField] GameObject BulletPrefab;
    [SerializeField] float timeRate;
    float nextTime = 0f;

    void StartMonitoring()
    {
        float distance_now = Vector3.Distance(TargetObject.position, ОbserverObject.position);
        if (distance_now <= distance)
        {
            var dir = ОbserverObject.position - TargetObject.position;
            var ndir = Vector3.RotateTowards(ОbserverObject.forward, dir, speed * Time.deltaTime, 0);
            ОbserverObject.rotation = Quaternion.LookRotation(ndir);
            if(Time.time > nextTime)
            {
                nextTime = Time.time + timeRate;
                BulletShoot();
            }
        }
        else
        {
            transform.Rotate(new Vector3(0f, speed*25f, 0f) * Time.deltaTime);
        }
    }
    void BulletShoot()
    {
        GameObject Bullet = Instantiate(BulletPrefab, transform.position, transform.rotation);
        Rigidbody rb = Bullet.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * BulletSpeed, ForceMode.VelocityChange);
    }

    void Start()
    {

    }
    void Update()
    {
        StartMonitoring();
    }
}
