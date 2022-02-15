using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeBall : MonoBehaviour
{
    [SerializeField] float LifeTime;
    float totalTime;
    void Start()
    {
        totalTime = Time.time + LifeTime;
    }
    void Update()
    {
        if (Time.time >= totalTime) Destroy(gameObject);
        
    }
}
