using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3_dz : MonoBehaviour
{
    public float javnaVrijednost;

    private void Update()
    {
        if(javnaVrijednost <= 100)
        {
            transform.localScale += new Vector3(javnaVrijednost, 0, 0);
            javnaVrijednost++;
        }
        else
        {
            transform.localScale += new Vector3(javnaVrijednost, javnaVrijednost, javnaVrijednost);
        }
    }
}
