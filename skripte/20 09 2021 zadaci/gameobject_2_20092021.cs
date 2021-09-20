using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_2_20092021 : MonoBehaviour
{
    public GameObject nekaj;

    private void Update()
    {
        if(nekaj.activeSelf)
        {
            nekaj.SetActive(false);
        }
        else if (!nekaj.activeSelf)
        {
            nekaj.SetActive(true);
        }
    }
}
