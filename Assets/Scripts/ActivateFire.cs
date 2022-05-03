using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFire : MonoBehaviour
{
    public GameObject IldParticle;

        private void OnTriggerEnter(Collider other)
     {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Ild")
        {
            IldParticle.SetActive(true);
        }
     }
}
