using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_6collision_17092021 : MonoBehaviour
{
    public int score;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Point")
        {
            score++;
            other.gameObject.SetActive(false);
        }
    }
}
