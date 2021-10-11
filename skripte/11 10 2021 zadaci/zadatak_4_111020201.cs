using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_4_111020201 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(UKurac());
        }
    }

    IEnumerator UKurac()
    {
        yield return new WaitForSeconds(5);
        Debug.Log ("Nisi uspio pobjeæi\nSada ideš u Brazil");
    }
}
