using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zadatak_3_12102021 : MonoBehaviour
{
    public Text ne�ta;

    private void Start()
    {
        Invoke("Retard", 10);
    }

    public void Retard()
    {
        ne�ta.text = "Bruh";
    }
}
