using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class TextToggleTrigger : MonoBehaviour
{

    void Start()
    {
        //Set the tag of this GameObject to Player
        gameObject.tag = "Hand";
    }

    public GameObject Textboks;
    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Brille")
        {
            Textboks.GetComponent<Renderer>().enabled = false;
        }
    }
}
