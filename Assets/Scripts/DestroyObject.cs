using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class DestroyObject : MonoBehaviour {
 
     void OnCollisionEnter(Collision collision)
     {
         Destroy(gameObject);
     }
 }
