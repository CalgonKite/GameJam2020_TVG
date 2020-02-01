using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2Boundary1 : MonoBehaviour
{
    public GameObject puzzleObjNeeded;
    public GameObject Particlesys;
    private void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<CogHolder1>().correctcog == true)
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Particlesys.SetActive(false);
        }
        else
        {
            gameObject.GetComponent<BoxCollider>().enabled = false;
            Particlesys.SetActive(true);
        }
    }
}
