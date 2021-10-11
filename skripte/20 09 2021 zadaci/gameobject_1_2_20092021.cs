using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_1_2_20092021 : MonoBehaviour
{
    GameObject Everything;
    private void Start()
    {
        Everything = this.gameObject;
        Destroy(Everything);
    }
}