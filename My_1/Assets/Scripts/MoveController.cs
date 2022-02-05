using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float Speed;
                     private float SpeedP;
    [SerializeField] private float PowerJump = 0f;
    [SerializeField] private bool isGraunded;
    
    private void RunSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            SpeedP = Speed + 5f;
        }
        else
        {
            SpeedP = Speed;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Graund")
            isGraunded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Graund")
            isGraunded = false;
    }
   
    void OnTriggerEnter(Collider other)
    {
        print(other.gameObject.name);

        if (other.gameObject.name == "eat Heal_kit(Clone)")
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
    void Update()
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");
        var c = Input.GetAxis("Jump");

        //if (isGraunded == false) c = 0f;
        var derectian = new Vector3(a, c * PowerJump, b);
        RunSpeed();
        transform.Translate(SpeedP * derectian * Time.deltaTime);
    }
}
