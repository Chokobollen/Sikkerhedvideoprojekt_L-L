using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCollider : MonoBehaviour
{
    public int sceneIndex;
    public GameObject Brille;
    public GameObject Tekst;
   
    void Start()
    {     
        //Set the tag of this GameObject to Player
        gameObject.tag = "Player";
    }

    private void OnTriggerEnter(Collider other)
    {
        //Check to see if the tag on the collider is equal to Enemy
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
