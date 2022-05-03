using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGas : MonoBehaviour
{
    private int i = 0;
    public bool GasUd;
    public GameObject target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            if (i == 0)
            {
                transform.GetChild(2).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                transform.GetChild(3).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                transform.GetChild(4).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                i++;
                GasUd = true;
            }
            else if (i == 1)
            {
                transform.GetChild(2).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                transform.GetChild(3).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                transform.GetChild(4).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                i--;
                GasUd = false;
            }
        }
    }
}
