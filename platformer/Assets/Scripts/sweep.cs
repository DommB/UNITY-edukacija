using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sweep : MonoBehaviour
{
    public float speed;
    bool direction;


    private void Update()
    {
        if(direction)
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }
        if(transform.position.z < -5)
        {
            direction = true;
        }
        else if(transform.position.z > 5)
        {
            direction = false;
        }
    }
}
