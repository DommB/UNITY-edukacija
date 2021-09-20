using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionMetode : MonoBehaviour
{
    //Barem jedan Rigidbody i 0 aktivnih IsTriggera
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Kontakt");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Diraju se");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Odvojenje");
    }
}
