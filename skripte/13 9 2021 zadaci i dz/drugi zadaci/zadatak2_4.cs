using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak2_4 : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(new Vector3(3, 3, 0) * Time.deltaTime);
    }
}
