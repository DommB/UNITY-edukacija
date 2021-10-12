using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_5_12102021 : MonoBehaviour
{
    public Text health;
    public float hp;

    private void Start()
    {
        HealthCheck();
        InvokeRepeating("AddHealth", 5, 5);
        InvokeRepeating("RemoveHealth", 10, 10);
    }

    public void AddHealth()
    {
        hp += 5;
        HealthCheck();
    }

    public void RemoveHealth()
    {
        hp *= 0.95f;
        HealthCheck();
    }

    private void OnTriggerStay(Collider other)
    {
        hp += 5 * Time.deltaTime;
        HealthCheck();
    }

    public void HealthCheck()
    {
        if (hp >= 100)
        {
            hp = 100;
        }
        else if (hp <= 0)
        {
            hp = 0;
        }

        health.text = hp.ToString();
    }
}
