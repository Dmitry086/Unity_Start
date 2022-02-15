using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MoveController : MonoBehaviour
{
    private Rigidbody _playerBody;
    [SerializeField] private float Speed;
    [SerializeField] private float SpeedRun;
    private float SpeedP;
    [SerializeField] private float PowerJump;
    [SerializeField] private bool isGraunded;

    private void Awake()
    {
        _playerBody = GetComponent<Rigidbody>();
    }
    private void RunSpeed()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            SpeedP = Speed + SpeedRun;
        }
        else
        {
            SpeedP = Speed;
        }
    }

    private void JumpPlayer()
    {
        if (Input.GetKeyDown(KeyCode.Space) & isGraunded == true) _playerBody.AddForce(Vector3.up * PowerJump, ForceMode.VelocityChange);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if(collision.gameObject.tag == "Graund")
    //        isGraunded = true;
    //}
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Graund")
            isGraunded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Graund")
            isGraunded = false;
    }
    void Start()
    {
        
    }
    void Update()
    {
        var a = Input.GetAxis("Horizontal");
        var b = Input.GetAxis("Vertical");
        //var c = Input.GetAxis("Jump");
        var derectian = new Vector3(a, 0, b);
        RunSpeed();
        transform.Translate(SpeedP * derectian * Time.deltaTime);
        JumpPlayer();
    }
}
