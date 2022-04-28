using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeadCollider : MonoBehaviour
{
  private void onTriggerEnter(Collider other)
  {
      if(other.tag == "Briler")
      SceneManager.LoadScene(0);
  }

}
