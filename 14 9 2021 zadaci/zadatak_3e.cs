using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3e : MonoBehaviour
{
    public float sclX;
    public float sclY;
    public float sclZ;
    public float posX;
    public float posY;
    public float posZ;
    float startPozX;
    float startPozY;
    float startPozZ;

    private void Start()
    {
        startPozX = transform.localScale.x;
        startPozY = transform.localScale.y;
        startPozZ = transform.localScale.z;
    }

    private void Update()
    {
        //g)
        if(sclX > 0 || sclY > 0 || sclZ > 0)
        {
            transform.position += new Vector3(posX, posY, posZ);
        }
        else if(sclX < 0 || sclY < 0 || sclZ < 0)
        {
            transform.position -= new Vector3(posX, posY, posZ);
        }

        //h)
        if(transform.localScale.x <= startPozX / 2 || transform.localScale.y <= startPozY / 2 || transform.localScale.z <= startPozZ / 2)
        {
            transform.position += new Vector3(posX, posY, posZ);
        }
        else if(transform.localScale.x >= startPozX * 2 || transform.localScale.y >= startPozY * 2 || transform.localScale.z >= startPozZ * 2)
        {
            transform.position -= new Vector3(posX, posY, posZ);
        }

        transform.localScale += new Vector3(sclX, sclY, sclZ) * Time.deltaTime;
    }


}
