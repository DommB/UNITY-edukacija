using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2 : MonoBehaviour
{
    public float scaleChange;

    private void Update()
    {
        transform.localScale += new Vector3(scaleChange, scaleChange, scaleChange);
    }
}