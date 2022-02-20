using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour

{
    [SerializeField] private GameObject prefabEnemyMelee;
    [SerializeField] private Transform[] spawnPointMelee;
    [SerializeField] private GameObject prefabEnemyRange;
    [SerializeField] private Transform[] spawnPointRange;
    [SerializeField] bool Player_in = false;
    public int EnemyCont;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_in = true;
            StartSpawnMelee();
            StartSpawnRange();
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Player_in = false;
    }

    void StartSpawnMelee()
    {
        for (int i = 0; i < spawnPointMelee.Length; i++)
        {
            Instantiate(prefabEnemyMelee, spawnPointMelee[i].transform.position, Quaternion.identity);
            EnemyCont++;
        }

    }
    void StartSpawnRange()
    {
        for (int i = 0; i < spawnPointRange.Length; i++)
        {
            Instantiate(prefabEnemyRange, spawnPointRange[i].transform.position, Quaternion.identity);
            EnemyCont++;
        }

    }





}

