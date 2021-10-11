using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_5_11102021 : MonoBehaviour
{
    public Text health;
    public float hp;

    private void Start()
    {
        health.text = hp.ToString();
        StartCoroutine(AddHealth());
        StartCoroutine(RemoveHealth());
    }
    
    IEnumerator AddHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            hp += 5;
            health.text = hp.ToString();
        }
    }

    IEnumerator RemoveHealth()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            hp *= 0.95f;
            health.text = hp.ToString();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            hp += 5 * Time.deltaTime;
            health.text = hp.ToString();
        }
    }
}
