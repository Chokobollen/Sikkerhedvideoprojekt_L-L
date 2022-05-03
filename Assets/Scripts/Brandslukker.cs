using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Brandslukker : MonoBehaviour
{
    [SerializeField] private GameObject prefab;    // hastigheden den får på    
    [SerializeField] private float speed;
    [SerializeField] private float scale = 1;
    [SerializeField] private float mass;    // Start is called before the first frame update    
    void Start()
    {
        prefab = Resources.Load("projectile") as GameObject;
    }    // Update is called once per frame    
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.RawButton.B));
        {            // nyt projektil            
            GameObject projectile = Instantiate(prefab) as GameObject;            // sted og retning            
            projectile.transform.position = transform.position + transform.forward * 2;            //størrelse
            projectile.transform.localScale = transform.localScale * scale;            // en variabl der indeholder Rigidbody
            Rigidbody rb = projectile.GetComponent<Rigidbody>();            // giver en hastighed
            rb.velocity = transform.forward * speed;
        }
    }
}