using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1_dz : MonoBehaviour
{
    public float x;
    public float y;

    private void Start()
    {
        transform.localScale += new Vector3(x + y, x + y, x + y);
    }
}
