using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logRotation : MonoBehaviour
{
    public float angularSpeed;
    private void Update()
    {
        transform.Rotate(Vector3.up * angularSpeed * Time.deltaTime);
    }
}
