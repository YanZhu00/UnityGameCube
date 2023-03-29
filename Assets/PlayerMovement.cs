using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 500;
    public float sideForce = 500;
    float jumpForce = 6;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //rb.AddForce(0, 0, forwardForce);
    }
    //We marked this as "Fixed"Update because we are using it to mess with physics
    void FixedUpdate ()
    {
        //Debug.Log(Time.deltaTime);
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if ( Input.GetKey("up"))
        {   
            if (rb.transform.position.y < 1.01 && rb.velocity.z < 30)
                rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("left"))
        {
            if (rb.transform.position.y < 1.01 && rb.velocity.x > -10)
                rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("right"))
        {
            if (rb.transform.position.y < 1.01 && rb.velocity.x < 10)
                rb.AddForce(sideForce * Time.deltaTime ,0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("down"))
        {
            if (rb.transform.position.y < 1.01 && rb.velocity.z > -10)
                rb.AddForce(0, 0, -forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        }
        /*
        if (Input.GetKey("space"))
        {
            Vector3 bar = transform.position;
            if (bar.y == 1.0)
                rb.AddForce(0, forwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        */
        if (Input.GetKey("space"))
        {
            Vector3 bar = transform.position;
            if (bar.y < 1.01)
            {
                float f = 6;
                rb.AddForce(0, jumpForce, 0, ForceMode.VelocityChange);
            }
        }
    }
}
