using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1 : MonoBehaviour
{
    private void Update()
    {   //a)
        transform.Rotate(new Vector3(0, 1, 0));

        //b)
        transform.Rotate(new Vector3(1, 1, 1));

        //c)
        transform.Rotate(new Vector3(0, -1, 0));

        //d)
        transform.Rotate(Vector3.right);
        transform.Rotate(Vector3.forward);

        //e)
        transform.position += Vector3.one;

        //f)
        transform.localScale += new Vector3(-1, -5, -1);
    }
}
