using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marbleMovement : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public float jump;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.left * speed);
            if (rb.velocity.x <= -speed)
            {
                rb.velocity = new Vector3(-speed, rb.velocity.y, rb.velocity.z);
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.right * speed);
            if (rb.velocity.x >= speed)
            {
                rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
            }
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionX;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.back * speed);
            if (rb.velocity.z <= -speed)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, -speed);
            }
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.AddForce(Vector3.forward * speed);
            if (rb.velocity.z >= speed)
            {
                rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, speed);
            }
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.velocity += new Vector3(0, jump, 0);
        }
    }
}
