using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1_15092021 : MonoBehaviour
{
    private void Start()
    {
        //a)
        Debug.Log(2 + 3 * 8);

        //b)
        Debug.Log(8 * (3 + 2));

        //c)
        Debug.Log(8 / 3 + 2);

        //d)
        Debug.Log(8 % 3 + 2);

        //e)
        Debug.Log(31 % 4 + 9 * 2);

        //f)
        Debug.Log(9 * (2) + 2);

        //g)
        //Debug.Log(9 / (4 >= 2 + 2));      //Ne možemo koristiti simbol >= u jednadžbi

        //h)
        //Debug.Log(9 * !3 + 2);            //Ne možemo koristiti izraz !3 u jednadžbi
    }
}