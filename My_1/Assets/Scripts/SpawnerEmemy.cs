using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEmemy : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemyM;
    [SerializeField]
    private Transform[] spawnPoint;
    [SerializeField]
    private int totalEnemy;

    private int randEnemy;
    private int randPoint;

    void Start()
    {
        StartSpawn();
    }

    //void Update()
    //{

    //}

    void StartSpawn()
    {
        for (int i = 0; i <= totalEnemy; i++)
        {
            randEnemy = Random.Range(0, enemyM.Length);
            randPoint = Random.Range(0, spawnPoint.Length);

            Instantiate(enemyM[randEnemy], spawnPoint[randPoint].transform.position, Quaternion.identity);
        }
    }
}
