using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollection : MonoBehaviour
{
    public float health;
    public float dmg;
    public int points;
    bool ded, won, bruhzil;
    bool msg = true;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Point")
        {
            points++;
            //nestane Point
            other.gameObject.SetActive(false);
            //za gašenje collidera
            //other.enabled = false;
        }

        if(other.gameObject.tag == "Schid")
        {
            health -= dmg;
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Brazil")
        {
            bruhzil = true;
            EndNote();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Crush")
        {
            health -= dmg;
        }
    }


    private void Update()
    {
        if (health <= 0)
        {
            ded = true;
            EndNote();
        }
        else if (points == 10)
        {
            won = true;
            EndNote();
        }

    }

    void EndNote()
    {
        if (ded && msg)
        {
            Debug.Log("OOOOOOOOOO NIGGA U DED");
            msg = false;
        }
        else if (won && msg)
        {
            Debug.Log("OOOOOOOOOO NIGGA U WON");
            msg = false;
        }
        else if (bruhzil && msg)
        {
            Debug.Log("Bem vindo ao Brasil\nnao resista");
            msg = false;
        }
    }
}
