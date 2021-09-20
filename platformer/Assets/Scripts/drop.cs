using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public float speed;
    bool direction;


    private void Update()
    {
        if (direction)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (transform.position.y < 2)
        {
            direction = true;
        }
        else if (transform.position.y > 10)
        {
            direction = false;
        }
    }
}
