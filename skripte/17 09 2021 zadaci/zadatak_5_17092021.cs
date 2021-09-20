using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_17092021 : MonoBehaviour
{
    public float health;
    public float healthRegen;
    public float dmg;
    float maxHealth;

    private void Start()
    {
        maxHealth = health;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            health -= dmg;
        }

        if(other.gameObject.tag == "Heal")
        {
            health -= dmg / 2;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Sfera")
        {
            health -= dmg * Time.deltaTime;
        }

        if(other.gameObject.tag == "Heal")
        {
            if(health < maxHealth)
            {
                health += healthRegen * Time.deltaTime;
            }
            else
            {
                health = maxHealth;
            }
        }
    }
}
