using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy_trap_Range : MonoBehaviour
{
    [SerializeField] private GameObject prefabEnemyRange;
    [SerializeField] private Transform[] spawnPointRange;
    public int EnemyCont;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") StartSpawnRange();
    }
    void StartSpawnRange()
    {
        for (int i = 0; i <= spawnPointRange.Length; i++)
        {
            Instantiate(prefabEnemyRange, spawnPointRange[i].transform.position, Quaternion.identity);
            EnemyCont++;
        }

    }
}
