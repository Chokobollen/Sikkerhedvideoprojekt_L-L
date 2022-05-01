using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToggleVenstre : MonoBehaviour
{
    private bool BrilleTaget;
    public GameObject Textboks;

    void Start()
    {
        BrilleTaget = false;
        gameObject.tag = "Venstre";
    }

    void Update()
    {
        if (BrilleTaget == true)
        {
            Textboks.GetComponent<Renderer>().enabled = false;
        }
        else if (BrilleTaget == false)
        {
            Textboks.GetComponent<Renderer>().enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Brille")
        {
            BrilleTaget = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Brille")
        {
            BrilleTaget = false;
        }
    }
}
