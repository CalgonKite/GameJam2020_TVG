using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3FinalBoundary : MonoBehaviour
{
    public GameObject boundary;
    public GameObject puzzleObjNeeded;
    public GameObject puzzleObjNeeded2;
    public GameObject puzzleObjNeeded3;
    public GameObject Particlesys;
    public GameObject Particlesys2;
    private void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<CogHolder2>().correctcog2 == true && puzzleObjNeeded2.GetComponent<PuzzleContainer1>().puzzle1Solved == true && puzzleObjNeeded3.GetComponent<PuzzleContainer2>().puzzle2Solved == true)
        {
            boundary.GetComponent<BoxCollider>().enabled = false;
            Particlesys.SetActive(false);
            Particlesys2.SetActive(false);
        }
        else
        {
            boundary.GetComponent<BoxCollider>().enabled = true;
            Particlesys.SetActive(true);
            Particlesys2.SetActive(true);
        }
    }
}
