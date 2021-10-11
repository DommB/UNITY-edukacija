using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_6_15092021 : MonoBehaviour
{
    public float yz;
    int n = 0;

    private void Start()
    {
        //for petlja
        //for(int i = 0; i <= 10; i++)
        //{
        //    transform.localScale -= new Vector3(0, yz, yz);
        //}

        //while petlja
        while(n <= 10)
        {
            transform.localScale -= new Vector3(0, yz, yz);
            n++;
        }
    }
}


