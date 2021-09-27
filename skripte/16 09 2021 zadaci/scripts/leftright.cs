using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftright : MonoBehaviour
{
    public float blockSpeed;
    public bool direction;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(direction)
        {
            transform.position += Vector3.forward * blockSpeed * Time.deltaTime;
        }
        else
        {
            transform.position -= Vector3.forward * blockSpeed * Time.deltaTime;
        }
        if(transform.position.z <= -4f)
        {
            direction = true;
        }
        else if(transform.position.z >= 4f)
        {
            direction = false;
        }
    }
}
