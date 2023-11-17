
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float ForwardSpeed = 800f;
    public float leftrightSpeed = 30f;
    Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);
        if (Input.GetKey("d"))
        {
            rb.AddForce(leftrightSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-leftrightSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
