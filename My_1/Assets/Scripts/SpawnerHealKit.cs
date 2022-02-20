using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHealKit : MonoBehaviour
{
    [SerializeField] private GameObject prefabHealKit;
    [SerializeField] private Transform[] spawnPoint;
    
    void Start()
    {
        StartSpawn();
    }

    void StartSpawn()
    {
        for (int i = 0; i < spawnPoint.Length; i++)
        {
            Instantiate(prefabHealKit, spawnPoint[i].transform.position, Quaternion.identity);
        }
    }
}
