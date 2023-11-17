
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public float ForwardSpeed = 850f;
    public float leftrightSpeed = 680f;//65f
    Rigidbody rb;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);
        /*if (Input.GetKey("d"))
        {
            rb.AddForce(leftrightSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-leftrightSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }*/

        float leftright = Input.GetAxis("Horizontal")*leftrightSpeed*Time.deltaTime;

        //rb.velocity = new Vector2(leftright * leftrightSpeed,rb.velocity.y);
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * leftright);
        }
        if (rb.position.y< -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
