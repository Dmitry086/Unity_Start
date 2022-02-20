using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy_trap : MonoBehaviour
{
    [SerializeField] private GameObject prefabEnemyMelee;
    [SerializeField] private Transform[] spawnPointMelee;

    public int EnemyCont;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") StartSpawnMelee();
    }
    void StartSpawnMelee()
    {
        for (int i = 0; i <= spawnPointMelee.Length; i++)
        {
            Instantiate(prefabEnemyMelee, spawnPointMelee[i].transform.position, Quaternion.identity);
            EnemyCont++;
        }

    }

}
