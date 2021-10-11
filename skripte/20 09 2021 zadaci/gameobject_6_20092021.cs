using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_6_20092021 : MonoBehaviour
{
    public GameObject izvorBuke;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            izvorBuke.gameObject.SetActive(!izvorBuke.activeSelf);
        }
    }
}
