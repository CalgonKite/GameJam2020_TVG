using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3ToggleBoundary : MonoBehaviour
{
    public GameObject boundary2;
    public GameObject boundary3;
    public GameObject puzzleObjNeeded;
    public GameObject b2Particlesys;
    public GameObject b3Particlesys;
    private void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<CogHolder1>().correctcog == true)
        {
            boundary2.GetComponent<BoxCollider>().enabled = false;
            b2Particlesys.SetActive(false);

            boundary3.GetComponent<BoxCollider>().enabled = true;
            b3Particlesys.SetActive(true);
        }
        else
        {
            boundary2.GetComponent<BoxCollider>().enabled = true;
            b2Particlesys.SetActive(true);

            boundary3.GetComponent<BoxCollider>().enabled = false;
            b3Particlesys.SetActive(false);
        }
    }
}
