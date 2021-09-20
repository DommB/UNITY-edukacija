using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_16092021 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.U))
        {
            rb.constraints = RigidbodyConstraints.None;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            rb.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}