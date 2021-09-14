using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatakDevet : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    public float posX;
    public float posY;
    public float posZ;
    public float sclX;
    public float sclY;
    public float sclZ;
    private void Update()
    {
        transform.localScale += new Vector3(sclX, sclY, sclZ) * Time.deltaTime;
        transform.position += new Vector3(posX, posY, posZ) * Time.deltaTime;
        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
    }
}
