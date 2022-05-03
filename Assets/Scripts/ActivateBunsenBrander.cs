using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivateBunsenBrander : MonoBehaviour
{
    //Opretter Booleaner til branderOn og GasOn
    public bool BranderOn;
    public bool GasOn;
    //Laver GameObjekter som vi kan tilføje vores tekstbokse i
    public GameObject Textboks;
    public GameObject Textboks2;
    public GameObject Textboks3;
    Collider ObjectCollider;
    //Tilknytter en værdi til scriptet for SnapToLocation
    SnapToLocation snapToLocation;
    //SerializeField gør vi kan se GameObjectet i vores inspector, men kan ikke påvirke den fra andre scripts
    [SerializeField] GameObject SnapToplaceObject;
    //Tilknytter en værdi til scriptet for ActivateGas
    ActivateGas activateGas;
    //SerializeField gør vi kan se GameObjectet i vores inspector, men kan ikke påvirke den fra andre scripts
    [SerializeField] GameObject ActivateGasObject;
    
    //Void Awake er det første som bliver loaded i scriptet
    void Awake()
    {    
        //Giver værdien objectCollider vejen collideren i objektet
        ObjectCollider = GetComponent<Collider>();
        //inspiration til at hente informationer fra andre scripts https://www.youtube.com/watch?v=Y7pp2gzCzUI
        //Laver genvej til scriptet SnapToLocation så der kan tilgås værdier
        snapToLocation = SnapToplaceObject.GetComponent<SnapToLocation>();
        //Laver genvej til scriptet ActivateGas så der kan tilgås værdier
        activateGas = ActivateGasObject.GetComponent<ActivateGas>();
    }

    //Tjekker om der der er et tag i collideren der er "Gas"
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Gas")
        {
            //Ændre boolean til true
            BranderOn = true;
        }
    }

    // Void update, opdatere for hvert frame
    void Update()
    {
        //Hvis både branderen og gassen er true vil den aktivere objektets colliders is trigger
        if (BranderOn == true && GasOn == true)
        {
            ObjectCollider.isTrigger = true;
        }
        
        //Giver BranderOn bool værdien for Snapped bool'en i Scriptet SnapToLocation
        BranderOn = snapToLocation.Snapped;
        //Giver GasOn bool værdien for GasUd bool'en i Scriptet ActivateGas
        GasOn = activateGas.GasUd;

        //Aktivere og deaktivere de følgende tekstbokse for at det den rigtige tekst som vises
        //Her er det når branderen er til
        if (BranderOn == true)
        {
            Textboks.SetActive(false);
            Textboks2.SetActive(true); 
        }

        //Her er det når både branderen er til og gassen er tændt
        if (BranderOn == true && GasOn == true)
        {
            Textboks2.SetActive(false); 
            Textboks3.SetActive(true); 

        }
    }
}
