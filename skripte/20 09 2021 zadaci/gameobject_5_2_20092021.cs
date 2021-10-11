using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_5_2_20092021 : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            this.enabled = false;
        }
    }
}
