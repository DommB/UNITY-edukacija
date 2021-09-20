using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3_2_16092021 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            rb.isKinematic = !rb.isKinematic;
        }

        if(Input.GetKeyDown(KeyCode.G))
        {
            rb.useGravity = !rb.useGravity;
        }
    }
}