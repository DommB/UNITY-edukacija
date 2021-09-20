using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Objekti mojau imati Rigidbody komponente i barem jedan mora imati IsTrigger true
public class triggerMetode : MonoBehaviour
{
    public float Health;
    //Izvr�ava se samo jedanput, u frameu kada jedan objekt u�e u drugi objekt sa barem jednim pixelom
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Entry");
    }

    //Izvr�ava se svaki frame dokle god je jedan objekt unutar drugog objekta
    private void OnTriggerStay(Collider other)
    {
        
    }

    //Izvr�ava se samo jedanput, u frameu kada jedan objekt u potpunosti iza�e iz drugog objekta
    private void OnTriggerExit(Collider other)
    {
        
    }
}
