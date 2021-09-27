using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_16092021 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezePositionX;
    }
}