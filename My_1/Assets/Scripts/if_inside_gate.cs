using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class if_inside_gate : MonoBehaviour
{
    bool Player_inside = false;
    [SerializeField] GameObject DestroyObjekt;
    [SerializeField] control_gates_up_down CloseObjekt;
    bool Close;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player") Player_inside = true;
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
