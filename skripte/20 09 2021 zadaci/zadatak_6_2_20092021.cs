using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_6_2_20092021 : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            Destroy(this.gameObject);
        }
    }
}
