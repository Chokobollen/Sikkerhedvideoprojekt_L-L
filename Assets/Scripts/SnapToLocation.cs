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
    //Et objekt så den ved hvor meget det andet GameObject skal roteres
    public GameObject SnapRotationReference;

    //Hvis det GameObject der kommer ind i collideren er det valgte GameObject vil insideSnapZone blive sat til true
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == BundsenBrander.name)
        {
            insideSnapZone = true;
        }
    }

    //Forlader bundsen branderen collideren vil insideSnapZone blive false
     private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == BundsenBrander.name)
        {
            insideSnapZone = false;
        }
    }

    //Funktion der sætter bundsen branderen fast på positionen og rotationen som vi tilgav dem via vores GameObjekter
    void SnapObject()
    {
        if (grabbed == false && insideSnapZone == true)
        {
            
            BundsenBrander.gameObject.transform.position = transform.position;
            BundsenBrander.gameObject.transform.rotation = SnapRotationReference.transform.rotation;
            //Ændre snapped til true da den nu sidder på sin plads
            Snapped = true;
        }
    }

    //Void update, opdatere hvert frame så, tæt på hele tiden.
    void Update()
    { 
        //Grabbed bliver tilknyttet til boot værdien fra OVRGrabbable scriptet. Værdien er isGrabbed fra OVRGrabbable
        grabbed = BundsenBrander.GetComponent<OVRGrabbable>().isGrabbed;
        //Kører funktionen SnapObject()
        SnapObject();
    }
}
