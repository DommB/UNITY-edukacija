using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_7_20092021 : MonoBehaviour
{
    public AudioClip clipL;
    public AudioClip clipQ;
    public AudioSource audSrc;

    private void Start()
    {
        audSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            audSrc.clip = clipL;
            audSrc.volume = 1;
            audSrc.Play();
        }

        if(Input.GetKeyDown(KeyCode.P))
        {
            audSrc.clip = clipQ;
            audSrc.volume = 0.5f;
            audSrc.Play();
        }
    }
}
