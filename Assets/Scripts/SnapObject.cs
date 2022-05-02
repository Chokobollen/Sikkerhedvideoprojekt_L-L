using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObject : MonoBehaviour
{
    public GameObject SnapLocation;

    public GameObject rocket;

    public GameObject Textboks;

    public bool isSnapped;

    private bool objectSnapped;

    private bool grabbed;

    void Update()
    {
        grabbed = GetComponent<OVRGrabbable>().isGrabbed;

        objectSnapped = SnapLocation.GetComponent<SnapToLocation>().Snapped;

        if (objectSnapped == true)
        {
            GetComponent<Rigidbody>().isKinematic = true;
            transform.SetParent(rocket.transform);
            isSnapped = true;
            Textboks.SetActive(false);
        }

        if (objectSnapped == false)
        {
            Textboks.SetActive(true);
        }

        if (objectSnapped == false && grabbed == false)
        {
            GetComponent<Rigidbody>().isKinematic = false;
        }

    }



}
