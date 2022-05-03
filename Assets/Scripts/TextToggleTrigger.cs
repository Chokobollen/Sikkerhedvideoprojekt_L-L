using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextToggleTrigger: MonoBehaviour
{
    //Opretter bool til at toggle om brillerne er taget af spilleren eller ej
    private bool BrilleTaget;
    public GameObject Textboks;
    public GameObject Textboks2;

    void Start()
    {
        BrilleTaget = false;
        gameObject.tag = "Brille";
    }

 //Tjekker om tagget "Hands" er inde i brillernes collider. Hvis de er sættes briller taget til true
    private void OnTriggerEnter(Collider other)
    {
        //Tjekker om tagget der kommer ind i collideren er "Hands"
        if (other.tag == "Hands")
        {
            BrilleTaget = true;
        }
    }

    //Tjekker om "hands" forlader collideren. Hvis den gør vil den ændre BrilleTaget til false
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Hands")
        { 
        BrilleTaget = false;
        }
    }

    // Void update, opdatere for hvert frame
    void Update()
    {
        //Er brillerne taget vil den ændre teksten til det vi ønsker
        if (BrilleTaget == true)
        {
            Textboks.SetActive(false);
            Textboks2.SetActive(true);
        }
        //Samt hvis de ikke er taget vil den gå tilbage til den normale tekst
        else if (BrilleTaget == false)
        {
            Textboks.SetActive(true);
            Textboks2.SetActive(false);
        }
    }

   
}


