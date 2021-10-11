using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_4_2_20092021 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            Destroy(this);
        }
    }
}