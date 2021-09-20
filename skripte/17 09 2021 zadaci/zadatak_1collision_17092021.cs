using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1collision_17092021 : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Udario ga je");
        }
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Još uvijek je u kontaktu");
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Odjebali su");
        }
    }
}
