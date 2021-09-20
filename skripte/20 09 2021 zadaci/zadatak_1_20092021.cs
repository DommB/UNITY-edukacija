using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_1_20092021 : MonoBehaviour
{
    public AudioSource ass;

    private void Start()
    {
        ass = GetComponent<AudioSource>();
        ass.Play();
    }
}
