using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_6_20092021 : MonoBehaviour
{
    AudioSource audioSrc;

    [Range(0, 1)]
    public float vol;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        audioSrc.volume = vol;
    }
}
