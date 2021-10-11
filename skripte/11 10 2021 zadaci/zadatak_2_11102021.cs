using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2_11102021 : MonoBehaviour
{
    public GameObject[] prefabovi;

    private void Start()
    {
        StartCoroutine(SpawnDaTing());
    }

    IEnumerator SpawnDaTing()
    {
        while (true)
        {
            Instantiate(prefabovi[Random.Range(0, prefabovi.Length)], new Vector3(Random.Range(0f, 10f), Random.Range(0f, 20f), Random.Range(-15f, 15f)), Quaternion.identity);
            yield return new WaitForSeconds(5);
        }
    }
}
