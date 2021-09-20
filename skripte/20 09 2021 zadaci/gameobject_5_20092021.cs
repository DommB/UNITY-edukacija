using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_5_20092021 : MonoBehaviour
{
    public GameObject prvi, drugi, treci, cetvrti, peti;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            prvi.gameObject.SetActive(!prvi.activeSelf);
            drugi.gameObject.SetActive(!drugi.activeSelf);
            treci.gameObject.SetActive(!treci.activeSelf);
            cetvrti.gameObject.SetActive(!cetvrti.activeSelf);
            peti.gameObject.SetActive(!peti.activeSelf);
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            treci.gameObject.SetActive(!treci.activeSelf);
        }
    }
}
