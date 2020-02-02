using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Boundary2 : MonoBehaviour
{
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
                gameObject.GetComponent<BoxCollider>().enabled = true;
                Particlesys.SetActive(true);
            }
        }
}