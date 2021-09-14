using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak2_6 : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    bool max;
    bool smjer;
    private void Update()
    {
        if (transform.localScale.x >= 25)
        {
            max = true;
            smjer = true;
        }
        else if (transform.localScale.x <= 1)
        {
            max = false;
            smjer = false;
        }

        if (!max && transform.localScale.x < 25)
        {
            transform.localScale += new Vector3(3, 3, 3);
        }
        else if (max && transform.localScale.x > 1)
        {
            transform.localScale -= new Vector3(3, 3, 3);
        }

        if(smjer)
        {
            transform.Rotate(new Vector3(rotX, rotY, rotZ));
        }
        else
        {
            transform.Rotate(new Vector3(rotX * -1, rotY * -1, rotZ * -1));
        }
    }
}
