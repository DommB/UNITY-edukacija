using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_2_16092021 : MonoBehaviour
{
    Rigidbody rb;
    public float force, jumpForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }

    private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.right * force);
        }

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector3.left * force);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.forward * force);
        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.back * force);
        }
    }
}