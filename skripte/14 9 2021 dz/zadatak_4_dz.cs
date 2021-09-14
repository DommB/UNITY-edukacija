using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_4_dz : MonoBehaviour
{
    public float sclX, sclY, sclZ, posX, posY, posZ, rotX, rotY, rotZ, zbrojScl, zbrojPos, zbrojRot;

    private void Start()
    {
        sclX = transform.localScale.x;
        sclY = transform.localScale.y;
        sclZ = transform.localScale.z;
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        rotX = transform.eulerAngles.x;
        rotY = transform.eulerAngles.y;
        rotZ = transform.eulerAngles.z;
        zbrojScl = sclX + sclY + sclZ;
        zbrojPos = posX + posY + posZ;
        zbrojRot = rotX + rotY + rotZ;

        if(zbrojScl > 20 || zbrojPos > 20 ||zbrojRot > 20)
        {
            transform.localScale = Vector3.one;
            transform.position = new Vector3(0, 0, 0);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.localScale += new Vector3(zbrojScl, zbrojScl, zbrojScl);
            transform.position += new Vector3(zbrojPos, zbrojPos, zbrojPos);
            transform.rotation = Quaternion.Euler(69, 420, 911);
        }
    }
}
