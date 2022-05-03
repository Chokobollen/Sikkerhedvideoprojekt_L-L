using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class DestroyObject : MonoBehaviour {
 
     void OnCollisionEnter(Collision collision) //Tjækker om der er en collision med en collider
     {
         Destroy(gameObject); //Fjerner objektet hvis true
     }
 }
