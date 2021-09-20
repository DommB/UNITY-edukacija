using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_4_20092021 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Sfera")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
