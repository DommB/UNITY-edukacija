using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3_16092021 : MonoBehaviour
{
    public float speed;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    //Kada koristimo sile, koristimo FixedUpdate

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.right * speed);
        //ili:
        //rb.AddForce(new Vector3(1, 0, 0) * speed);
        //rb.AddForce(new Vector3(speed, 0, 0));
        //rb.AddForce(transform.right * speed);
    }
}