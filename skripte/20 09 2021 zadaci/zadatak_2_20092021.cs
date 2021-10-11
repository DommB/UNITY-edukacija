using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_2_20092021 : MonoBehaviour
{
    public AudioSource audSrc;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(audSrc.isPlaying)
        {
            audSrc.Stop();
        }
        else
        {
            audSrc.Play();
        }
    }
}
