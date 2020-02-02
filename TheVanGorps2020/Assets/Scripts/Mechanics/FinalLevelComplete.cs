using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalLevelComplete : MonoBehaviour
{

    public GameObject puzzleObjNeeded;
    public GameObject puzzleObjNeeded2;
    public GameObject puzzleObjNeeded3;
    public GameObject puzzleObjNeeded4;
    public GameObject Particlesys;
    public GameObject Particlesys2;
    public GameObject Particlesys3;
    public GameObject CogBrain;
    public bool steam1, steam2, steam3, pushPuzzleSolved; 

    private void LateUpdate()
    {
        if (puzzleObjNeeded.GetComponent<CogHolder1>().correctcog == true)
        {   Particlesys.SetActive(true);    steam1 = true;  }
        else
        {   Particlesys.SetActive(false);   steam1 = false;  }

        if (puzzleObjNeeded2.GetComponent<CogHolder2>().correctcog2 == true)
        {   Particlesys2.SetActive(true);   steam2 = true;  }
        else
        {   Particlesys2.SetActive(false);  steam2 = false; }

        if (puzzleObjNeeded3.GetComponent<CogHolder3>().correctcog3 == true)
        {   Particlesys3.SetActive(true);   steam3 = true; }
        else
        {   Particlesys3.SetActive(false);  steam3 = false; }

        if (puzzleObjNeeded4.GetComponent<PuzzleContainer1>().puzzle1Solved == true)
        { pushPuzzleSolved = true; }
        else
        { pushPuzzleSolved = false; }


        if (steam1 == true && steam2 == true && steam3 == true && pushPuzzleSolved == true)
        {
            //DO THINGS
            Debug.Log("START MAKING THE END GAME");
        }
    }
}