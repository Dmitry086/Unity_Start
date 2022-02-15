using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Take_som_player : MonoBehaviour
{
    void OnTriggerEnter(Collider Collider)
    {
        if (Collider.gameObject.tag == "HealKit")//Съесть Аптечку
        {
            print("Player ate " + Collider.gameObject.name);
            Destroy(Collider.gameObject);
        }
        if (Collider.gameObject.tag == "Mines")//Мина удаляет игрока
        {
            print("Player Dead of " + Collider.gameObject.name);
            Destroy(gameObject);
        }
    }
}