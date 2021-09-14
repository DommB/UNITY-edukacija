using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2_dz : MonoBehaviour
{
    public float x;
    public int a;
    float ax;

    private void Start()
    {
        ax = x + a;
        if(ax > 20)
        {
            transform.localScale += new Vector3(20, 20, 20);
        }
        else
        {
            transform.localScale -= new Vector3(ax, ax, ax);
        }
    }
}