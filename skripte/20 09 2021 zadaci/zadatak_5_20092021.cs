using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_5_20092021 : MonoBehaviour
{
    public AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            audioSrc.Play();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            audioSrc.Pause();
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            audioSrc.UnPause();
        }
        else if (Input.GetKeyDown(KeyCode.M))
        {
            audioSrc.mute = !audioSrc.mute;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            audioSrc.Stop();
        }
    }
}
