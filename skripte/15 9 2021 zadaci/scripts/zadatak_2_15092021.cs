using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2_15092021 : MonoBehaviour
{
    int i;
    string c;
    float d;

    private void Start()
    {
        i = 1;
        c = "Bruh";
        d = 9.11f;

        //a)
        Debug.Log(c + 2.1f);

        //b)
        Debug.Log(d + c);

        //c)
        Debug.Log(3.14f * d);

        //d)
        Debug.Log(i * 3);

        //e)
        Debug.Log(c + "2");

        //f)
        Debug.Log(d + c);

        //g)
        //Debug.Log("2" * d);           //Ne možemo množiti string i float

        //h)
        //Debug.Log(i * "2");           //Ne možemo množiti string i int
    }
}