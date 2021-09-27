using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_15092021 : MonoBehaviour
{
    public float x;
    int n = 0;

    private void Start()
    {
        //for petlja
        //for(int i = 0; i < x; i++)
        //{
        //    transform.localScale += new Vector3(x, 0, 0);
        //}

        //while petlja
        while(n < x)
        {
            transform.localScale += new Vector3(x, 0, 0);
            n++;
        }
    }
}