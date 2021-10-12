using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_12102021 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Invoke("UKurac", 5);
    }

    public void UKurac()
    {
        Debug.Log("Ideš u Brazil");
    }
}
