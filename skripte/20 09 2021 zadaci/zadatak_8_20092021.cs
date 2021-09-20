using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_8_20092021 : MonoBehaviour
{
    public AudioSource as1;
    public AudioSource as2;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(as1.enabled)
            {
                as1.enabled = false;
                as2.enabled = true;
            }
            else if (as2.enabled)
            {
                as1.enabled = true;
                as2.enabled = false;
            }
        }
    }
}
