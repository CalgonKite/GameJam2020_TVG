using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial2Boundary2 : MonoBehaviour
{
    //PROGRAMMED BY LEE FEARNETT

    public GameObject puzzleObjNeeded;
    public GameObject Particlesys;
    private void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<CogHolder2>().correctcog2 == true)
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
