using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_2_2_20092021 : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Destroy(this);
        }
    }
}
