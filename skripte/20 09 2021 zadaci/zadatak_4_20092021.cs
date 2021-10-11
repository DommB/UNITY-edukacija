using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_20092021 : MonoBehaviour
{
    public AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (audioSrc.mute)
        {
            audioSrc.mute = false;
        }
        else
        {
            audioSrc.mute = true;
        }
    }
}