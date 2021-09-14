using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak10 : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    public float sclX;
    public float sclY;
    public float sclZ;
    bool minmax;
    private void Update()
    {
        if (transform.localScale.x >= 10)
        {
            minmax = true;
        }
        else if (transform.localScale.x <= 0.1f)
        {
            minmax = false;
        }

        if(!minmax && transform.localScale.x < 10f)
        {
            transform.localScale += new Vector3(sclX, sclY, sclZ);
        }
        else if(minmax && transform.localScale.x > 0.1f)
        {
            transform.localScale -= new Vector3(sclX, sclY, sclZ);
        }

        transform.Rotate(new Vector3(rotX, rotY, rotZ));
    }
}
