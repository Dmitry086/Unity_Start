using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Heal_kit : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToClone;

    private GameObject heal_kit_1;
    private GameObject heal_kit_2;
    void Start()
    {
        //heal_kit_1 = Instantiate(objectToClone, new Vector3(-8.882859f, 5.357151f, 20.29442f), Quaternion.identity);
        //heal_kit_2 = Instantiate(objectToClone, new Vector3(-8.882859f, 5.357151f, 12.29442f), Quaternion.identity);

        InvokeRepeating("Check_Heal_kit_1", 15f * Time.deltaTime, 10f);
        InvokeRepeating("Check_Heal_kit_2", 15f * Time.deltaTime, 20f);
    }
    //void Update()
    //{

    //}
    void Check_Heal_kit_1()
    {
        if (!heal_kit_1)
        {
            heal_kit_1 = Instantiate(objectToClone, new Vector3(-8.882859f, 5.357151f, 20.29442f), Quaternion.identity);
        }
    }
    void Check_Heal_kit_2()
    {
        if (!heal_kit_2)
        {
            heal_kit_2 = Instantiate(objectToClone, new Vector3(-8.882859f, 5.357151f, 12.29442f), Quaternion.identity);
        }
    }




}
