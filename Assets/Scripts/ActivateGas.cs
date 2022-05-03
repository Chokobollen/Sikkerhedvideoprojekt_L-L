using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateGas : MonoBehaviour
{
    //Opretter en int værdi i som er lig 0 til start
    private int i = 0;
    public bool GasUd;
    //Opretter et GameObject kaldet target som kan reffereres til i koden
    public GameObject target;

    //Når tagget "Hands" kommer ind i collideren
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hands")
        {
            //Opstiller et if statement for i. i=0
            if (i == 0)
            {
                //Tager tager de forskellige Childs for at roterer dem. De roteres om punktet target, 90 grader i 1 sek
                transform.GetChild(2).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                transform.GetChild(3).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                transform.GetChild(4).RotateAround(target.transform.position, Vector3.up, 90 * 1);
                //Tilføjer 1 til int i, for at benytte den næste if statement næste gang funktionen kaldes
                i++;
                //Ændre GasUd til true
                GasUd = true;
            }

            //Opstiller et andet if statement. At i skal være 1
            else if (i == 1)
            {
                /*Tager ligesom det forrigede, forskellige Childs for at roterer dem. De roteres om punktet target, her dog -90 grader i 1 sek
                Her bevæger den modsat den forrige for at gå tilbage til standard position*/
                transform.GetChild(2).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                transform.GetChild(3).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                transform.GetChild(4).RotateAround(target.transform.position, Vector3.up, -90 * 1);
                //Trækker 1 fra i for at den passer til det andet if statement
                i--;
                //Sætter GasUd til false
                GasUd = false;
            }
        }
    }
}
