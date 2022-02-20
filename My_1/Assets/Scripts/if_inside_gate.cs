using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_inside_gate : MonoBehaviour
{
    public bool Player_inside = false;
    [SerializeField] GameObject DestroyObjekt;
    [SerializeField] control_gates_up_down CloseObjekt;


    [SerializeField] private GameObject prefabEnemyMelee;
    [SerializeField] private Transform[] spawnPointMelee;
    [SerializeField] private GameObject prefabEnemyRange;
    [SerializeField] private Transform[] spawnPointRange;
    [SerializeField] Gate_rotation GateUp;
    


    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player_inside = true;
            for (int i = 0; i < spawnPointMelee.Length; i++)
            {
                GameObject EnemyTrap = Instantiate(prefabEnemyMelee, spawnPointMelee[i].transform.position, Quaternion.identity);
                EnemyTrap.tag = "EnemyTrap";
                GateUp.enemyCount++;
                
            }
            for (int i = 0; i < spawnPointRange.Length; i++)
            {
                Instantiate(prefabEnemyRange, spawnPointRange[i].transform.position, Quaternion.identity);
                gameObject.tag = "EnemyTrap";
                GateUp.enemyCount++;
            }
        }
    }
    void Update()
    {
        if (Player_inside)
        {
            CloseObjekt.isControlDown = false;
            Destroy(DestroyObjekt);
        }
    }


}
