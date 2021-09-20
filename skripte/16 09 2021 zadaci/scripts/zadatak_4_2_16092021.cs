using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_2_16092021 : MonoBehaviour
{
    Rigidbody rb;

    private void Start()
    {
        var g = GetComponent<Rigidbody>().useGravity = false;
    }
}