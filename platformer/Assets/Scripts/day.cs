using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(Vector3.up * 36 * Time.deltaTime);
    }
}
