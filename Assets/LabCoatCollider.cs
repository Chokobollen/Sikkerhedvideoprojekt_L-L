using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LabCoatCollider : MonoBehaviour
{
    //Laver 3 gameobjects
    public GameObject Textboks;
    public GameObject LabCoat1;
    public GameObject LabCoat2;

    //Her bliver der checket om der er et objekt der collider med dette objekt
    private void OnTriggerEnter(Collider other)
    {
        /*Her checker den saa om det andet objekt har tagget 'Hands'
        Hvis det er ja saa starter den coroutinen 'timer'*/
        if (other.tag == "Hands")
        {
           StartCoroutine(timer());
        }   
    }

    /*Her bliver coroutinen kaldt og saetter labcoatens 2 dele til ikke at vaere aktive
    Derefter blvier der aktiveret en tekstboks og sae venter denne del 5 sekunder og loader naeste del.*/
    IEnumerator timer()
    {
        LabCoat1.SetActive(false);
        LabCoat2.SetActive(false);
        Textboks.SetActive(true);
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(0);
    }

}
