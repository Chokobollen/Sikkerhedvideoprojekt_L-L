//https://www.youtube.com/watch?v=DEtZUeVY9qk

using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Brandslukker : MonoBehaviour
{
    [SerializeField] private GameObject prefab;     //Giver mulighed for at aendre paa variablerne i inspectoren   
    [SerializeField] private float speed;
    [SerializeField] private float scale = 1;
    [SerializeField] private float mass;      
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject; //Henter projektil prefaben ind i scriptet
    }     
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B)); //Checker for controller imput
        {                        
            GameObject projectile = Instantiate(prefab) as GameObject; //Saetter projectile prefabet som gameobjekt
            projectile.transform.position = transform.position + transform.forward * 2; //Tager sted og beregner retning
            projectile.transform.localScale = transform.localScale * scale; //Skifter stoerelse paa skummmet
            Rigidbody rb = projectile.GetComponent<Rigidbody>(); //Tilfoejer rigidbody
            rb.velocity = transform.forward * speed;  //Regner hastigheden ud paa projektilen
        }
    }
}