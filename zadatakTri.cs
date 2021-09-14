using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatakTri : MonoBehaviour
{
    public float rot;
    private void Update()
    {
        transform.Rotate(new Vector3(rot, rot, rot) * Time.deltaTime);
    }
}
