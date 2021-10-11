using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_3_11102021 : MonoBehaviour
{
    public Text kurac;

    private void Start()
    {
        StartCoroutine(PièkaMaterina());
    }

    IEnumerator PièkaMaterina()
    {
        yield return new WaitForSeconds(10);
        kurac.text = "Bravo!";
    }
}
