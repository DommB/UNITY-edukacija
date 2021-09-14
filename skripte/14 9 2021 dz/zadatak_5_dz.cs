using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_dz : MonoBehaviour
{
    public int int1;
    public int int2;
    public float float1;
    public float float2;

    private void Update()
    {
        if(int1 * int2 + float1 - float2 * int1 >= int1 * int2 * float1 / float2)
        {
            transform.localScale += Vector3.one * Time.deltaTime;
            transform.Rotate(new Vector3(2, 2, 2) * Time.deltaTime);
        }
        else
        {
            transform.localScale -= new Vector3(2, 2, 2) * Time.deltaTime;
            transform.Rotate(Vector3.one * Time.deltaTime);
        }
    }
}
