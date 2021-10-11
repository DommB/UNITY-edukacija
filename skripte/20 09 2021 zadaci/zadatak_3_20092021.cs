using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3_20092021 : MonoBehaviour
{
    public AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            audioSrc.mute = true;
        }

        if(Input.GetKeyDown(KeyCode.K))
        {
            audioSrc.mute = false;
        }
    }
}
