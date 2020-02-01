using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1BoundaryDestroy : MonoBehaviour
{
    public GameObject PuzzleObjNeeded;
    private void LateUpdate()
    {
        if (PuzzleObjNeeded.GetComponent<PuzzleContainer1>().puzzle1Solved == true)
        {
            Destroy(gameObject);
        }
    }
}
