using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformScale : MonoBehaviour
{
    private void Update()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
    }
}
