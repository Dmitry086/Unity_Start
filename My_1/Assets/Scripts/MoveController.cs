using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField]
    private float Speed = 1;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);
        //string hk = other.gameObject.name;

        if (other.gameObject.name == "Heal_kit(Clone)")
        {
            Destroy(other.gameObject);
        }
        else
        {
            print(other.gameObject.name + "can't eat");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");

        var derectian = new Vector3(a, 0, b);

        transform.Translate(Speed * derectian * Time.deltaTime);
    }
}
