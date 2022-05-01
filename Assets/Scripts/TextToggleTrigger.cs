using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToggleTrigger: MonoBehaviour
{
    private bool BrilleTaget;
    public GameObject Textboks;
    public GameObject Textboks2;

    void Start()
    {
        BrilleTaget = false;
        gameObject.tag = "Brille";
    }

    void Update()
    {
        if (BrilleTaget == true)
        {
            Textboks.SetActive(false);
            Textboks2.SetActive(true);
        }
        else if (BrilleTaget == false)
        {
            Textboks.SetActive(true);
            Textboks2.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Hands")
        {
            BrilleTaget = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hands")
        { 
        BrilleTaget = false;
        }
    }
}


