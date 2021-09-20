using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class auk : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(1, 1, 0) * 36 * Time.deltaTime);
    }
}
