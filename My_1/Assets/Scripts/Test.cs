using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int a = 1;
    int b = 0;

    // Update is called once per frame
    void Update()
    {
        while(b <= 5)
        {
            Debug.Log(a);
            a++;
            b++;
        }
    }
}
