using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Boundary2 : MonoBehaviour
{

    public GameObject boundary;
    public GameObject Particlesys;
    public GameObject puzzleObjNeeded;
    public GameObject puzzleObjNeeded2;
    public GameObject puzzleObjNeeded3;

    void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<PuzzleContainer1>().puzzle1Solved == true && puzzleObjNeeded2.GetComponent<PuzzleContainer2>().puzzle2Solved == true && puzzleObjNeeded3.GetComponent<PuzzleContainer3>().puzzle3Solved == true)
        {
            boundary.GetComponent<BoxCollider>().enabled = false;
            Particlesys.SetActive(false);
        }
        else
        {
            boundary.GetComponent<BoxCollider>().enabled = true;
            Particlesys.SetActive(true);
        }
    }
}