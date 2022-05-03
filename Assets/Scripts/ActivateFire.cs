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
        //Ser om tagget for objektet i collideren er "Ild"
        if (other.tag == "Ild")
        {
            //Gør man kan se partiklerne fra ild
            IldParticle.SetActive(true);
            //Starter timer scriptet
            StartCoroutine(timer());
        }
     }
     //Her bliver coroutinen kaldt og starter en timer på 5 sekunder for at man ikke kommer i en ny scene med det samme.
     IEnumerator timer()
        {
            yield return new WaitForSeconds(5);
            SceneManager.LoadScene(sceneIndex);
        }

}
