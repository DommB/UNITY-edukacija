using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1_16092021 : MonoBehaviour
{
    public Rigidbody rb;
    bool zaGravitaciju;

    //ili
    private void Start()
    {
        //rb = GetComponent<Rigidbody>();

        //za uzimanje gravitacije
        //zaGravitaciju = GetComponent<Rigidbody>().useGravity;
    }
}