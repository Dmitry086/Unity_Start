using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemyTrap : MonoBehaviour
{
    [SerializeField] int MaxHP;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BallBullet")
            MaxHP--;
    }

    void Update()
    {
        if (MaxHP == 0)
        {
            GameObject.FindGameObjectWithTag("GateTrap").GetComponent<Gate_rotation>().enemyCount--;
            Destroy(gameObject);
        }
    }
}
