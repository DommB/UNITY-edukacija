using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameobject_7_20092021 : MonoBehaviour
{
    Rigidbody rb;
    public GameObject sfera1;
    public GameObject sfera2;
    public GameObject kapsula1;
    public GameObject kapsula2;
    public GameObject kapsula3;
    public GameObject kapsula4;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        sfera1.SetActive(true);
        sfera2.SetActive(true);
        kapsula1.SetActive(false);
        kapsula2.SetActive(false);
        kapsula3.SetActive(false);
        kapsula4.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.velocity = Vector3.back * 5;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.constraints = RigidbodyConstraints.FreezeRotation;
            rb.velocity = Vector3.forward * 5;
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            rb.velocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sfera")
        {
            other.gameObject.SetActive(false);
            kapsula1.SetActive(true);
            kapsula2.SetActive(true);
            kapsula3.SetActive(true);
            kapsula4.SetActive(true);
        }

        else if(other.gameObject.tag == "Kapsula")
        {
            kapsula1.SetActive(false);
            kapsula2.SetActive(false);
            kapsula3.SetActive(false);
            kapsula4.SetActive(false);
        }
    }
}
