using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCollider : MonoBehaviour
{
    public int sceneIndex; //Saetter en integer til sceneIndex saa vi kan gaa videre til naeste scene 
    public GameObject Brille;
    public GameObject Tekst;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Brille")
        {
            StartCoroutine(timer());
        }
    }
    
    IEnumerator timer()
    {
        Brille.SetActive(false);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(sceneIndex);
    }

}
