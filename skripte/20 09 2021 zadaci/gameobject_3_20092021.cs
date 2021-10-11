using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_3_20092021 : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.SetActive(false);
        }
    }
}
