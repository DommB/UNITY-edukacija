using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    public float tiltSpeed;

    private void Update()
    {
        transform.Rotate(Vector3.up * tiltSpeed);
    }
}
