using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_17092021 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    public float dmg;
    float maxHealth;
    bool regenTrig;

    private void Start()
    {
        maxHealth = health;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            health -= dmg;
            regenTrig = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            health -= dmg * Time.deltaTime;
        }
    }

    void OnTriggerExit(Collider other)
    {
        regenTrig = true;
    }

    private void Update()
    {
        if (regenTrig)
        {
            health += healthRegen * Time.deltaTime;
        }

        if(health >= maxHealth)
        {
            health = maxHealth;
            regenTrig = false;
        }
    }
}
