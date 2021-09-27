using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2_2_16092021 : MonoBehaviour
{
    public float effect;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.mass = effect;
    }
}