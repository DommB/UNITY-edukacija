using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dz_6_16092021 : MonoBehaviour
{
    Rigidbody rb;
    public float yield;
    public float killZone;
    public float blastLift;
    Vector3 groundZero;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        groundZero = transform.position;
        rb.AddExplosionForce(yield, groundZero, killZone, blastLift);
    }
}
