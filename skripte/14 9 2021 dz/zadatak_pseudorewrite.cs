using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_pseudorewrite : MonoBehaviour
{
    float z = 12;

    private void Start()
    {
        Debug.Log(z);
        z += 2;
        Debug.Log(z);
        z -= z * 0.02f;
        Debug.Log(z);
    }
}
