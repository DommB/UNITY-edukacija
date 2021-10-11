using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3_17092021 : MonoBehaviour
{
    public float Health;

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            Health -= 5 * Time.deltaTime;
        }
    }
}
