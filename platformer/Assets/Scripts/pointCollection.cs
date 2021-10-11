using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCollection : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip scored;
    public AudioClip dieded;
    public float health;
    public float dmg;
    public int points;
    bool bruhzil;
    bool msg = true;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Point")
        {
            points++;
            audioSrc.clip = scored;
            audioSrc.Play();
            other.gameObject.SetActive(false);
        }

        if(other.gameObject.tag == "Schid")
        {
            health -= dmg;
            audioSrc.clip = dieded;
            audioSrc.Play();
            other.gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Brazil")
        {
            bruhzil = true;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Crush")
        {
            health -= dmg;
            audioSrc.clip = dieded;
            audioSrc.Play();
        }
    }


    private void Update()
    {
        if (health <= 0 && msg)
        {
            Debug.Log("OOOOOOOOOO NIGGA U DED");
            msg = false;
        }
        else if (points == 10 && msg)
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
