using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapToLocation : MonoBehaviour
{
    private bool grabbed;
    
    private bool insideSnapZone;

    public bool Snapped;

    public GameObject RocketPart;

    public GameObject SnapRotationReference;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == RocketPart.name)
        {
            insideSnapZone = true;
        }
    }

     private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == RocketPart.name)
        {
            insideSnapZone = false;
        }
    }

    void SnapObject()
    {
        if (grabbed == false && insideSnapZone == true)
        {
            RocketPart.gameObject.transform.position = transform.position;
            RocketPart.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            Snapped = true;
        }
    }

    void Update()
    {
        grabbed = RocketPart.GetComponent<OVRGrabbable>().isGrabbed;
        SnapObject();
    }
}
