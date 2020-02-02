using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBoundary1 : MonoBehaviour
{
    //PROGRAMMED BY LEE FEARNETT

    public GameObject PuzzleObjNeeded;
    private void LateUpdate()
    {
        if (PuzzleObjNeeded.GetComponent<PuzzleContainer1>().puzzle1Solved == true)
        {
            Destroy(gameObject);
        }
    }
}
