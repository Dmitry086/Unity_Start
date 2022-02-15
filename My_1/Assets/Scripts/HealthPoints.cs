using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPoints : MonoBehaviour
{
    [SerializeField] int MaxHP;
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "BallBullet")
            MaxHP--;
            print(gameObject.name + " HP:" + MaxHP);
    }

    void Update()
    {
        if(MaxHP == 0) Destroy(gameObject);
    }
}
