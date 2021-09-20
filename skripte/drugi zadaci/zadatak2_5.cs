using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak2_5 : MonoBehaviour
{
    private void Awake()
    {
        transform.localScale += new Vector3(0, 0, 89);
    }

    private void Start()
    {
        Debug.Log("Broj žrtava 9/11 je: " + transform.localScale.z);
    }

    private void Update()
    {
        transform.localScale += new Vector3(0, 0.25f, 0);
    }
}
