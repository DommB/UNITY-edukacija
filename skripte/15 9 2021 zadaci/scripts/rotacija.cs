using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotacija : MonoBehaviour
{
    public float rotY;

    private void Update()
    {
        transform.Rotate(new Vector3(0, rotY, 0) * Time.deltaTime);
    }
}