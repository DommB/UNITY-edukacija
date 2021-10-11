using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_6_17092021 : MonoBehaviour
{
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Point")
        {
            score++;
        }
    }
}
