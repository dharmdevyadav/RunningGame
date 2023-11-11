using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForwardSpeed = 1000f;
    public float leftrightSpeed = 500f;
    Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);
        if (Input.GetKey("a"))
        {
            rb.AddForce(leftrightSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(0, leftrightSpeed * Time.deltaTime, 0);
        }
    }
}
