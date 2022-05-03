using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivateFire : MonoBehaviour
{
    public GameObject IldParticle;
    public int sceneIndex;

        private void OnTriggerEnter(Collider other)
     {
        //Check to see if the tag on the collider is equal to Enemy
        if (other.tag == "Ild")
        {
            IldParticle.SetActive(true);
            StartCoroutine(timer());
        }
     }
     
     IEnumerator timer()
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(sceneIndex);
        }

}
