using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{
    //Opretter bool for at registrer om objektet er taget
    private bool grabbed;
    //Opretter bool for at registrer om objektet er i snapzonen
    public bool insideSnapZone;
    //Opretter bool for at registrer om objekktet er snappet på plads
    public bool Snapped;

    //Opretter GameObject plads så koden ved har et GameObject at bruge
    public GameObject BundsenBrander;

    public GameObject SnapRotationReference;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == BundsenBrander.name)
        {
            insideSnapZone = true;
        }
    }

     private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == BundsenBrander.name)
        {
            insideSnapZone = false;
        }
    }

    void SnapObject()
    {
        if (grabbed == false && insideSnapZone == true)
        {
            BundsenBrander.gameObject.transform.position = transform.position;
            BundsenBrander.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            Snapped = true;
        }
    }

    void Update()
    { 
        grabbed = BundsenBrander.GetComponent<OVRGrabbable>().isGrabbed;
        SnapObject();
    }
}
