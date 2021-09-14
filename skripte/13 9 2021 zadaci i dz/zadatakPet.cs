using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatakPet : MonoBehaviour
{
    public float sclX, sclY, sclZ;

    private void Start()
    {
        transform.localScale += new Vector3(sclX, sclY, sclZ);
    }

    private void Update()
    {
        transform.localScale += new Vector3(sclX, sclY, sclZ) * Time.deltaTime;
    }
}
