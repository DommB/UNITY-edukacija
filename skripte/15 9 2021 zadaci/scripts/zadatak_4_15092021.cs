using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_15092021 : MonoBehaviour
{
    float sclX;
    float sclY;
    float sclZ;

    private void Start()
    {
        sclX = transform.localScale.x;
        sclY = transform.localScale.y;
        sclZ = transform.localScale.z;
        transform.localScale = new Vector3(sclX, sclY, sclZ) * -1;
    }
}