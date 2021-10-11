using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_8_20092021 : MonoBehaviour
{
    public GameObject benis;
    bool ajdNeSeri = true;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            ajdNeSeri = !ajdNeSeri;
        }

        if(ajdNeSeri)
        {
            PaliGasi();
        }
    }

    void PaliGasi()
    {
        benis.SetActive(!benis.activeSelf);
    }
}
