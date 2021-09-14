using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadatak_3f : MonoBehaviour
{
    public float rotX;
    public float rotY;
    public float rotZ;
    public float posX;
    public float posY;
    public float posZ;
    float startPozX;
    float startPozY;
    float startPozZ;

    private void Start()
    {
        startPozX = transform.eulerAngles.x;
        startPozY = transform.eulerAngles.y;
        startPozZ = transform.eulerAngles.z;
    }

    private void Update()
    {
        //g)
        if (rotX > 0 || rotY > 0 || rotZ > 0)
        {
            transform.position += new Vector3(posX, posY, posZ);
        }
        else if (rotX < 0 || rotY < 0 || rotZ < 0)
        {
            transform.position -= new Vector3(posX, posY, posZ);
        }

        //h)
        if (transform.eulerAngles.x <= -startPozX || transform.eulerAngles.y <= -startPozY || transform.eulerAngles.z <= -startPozZ)
        {
            transform.position += new Vector3(posX, posY, posZ);
        }
        else if (transform.eulerAngles.x >= startPozX * 2 || transform.eulerAngles.y >= startPozY * 2 || transform.eulerAngles.z >= startPozZ * 2)
        {
            transform.position -= new Vector3(posX, posY, posZ);
        }

        transform.Rotate(new Vector3(rotX, rotY, rotZ) * Time.deltaTime);
    }
}
