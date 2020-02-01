using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleContainer1 : MonoBehaviour
{
    //Programed by Lee Fearnett

    public bool puzzle1Solved = false;
    public GameObject Container;

    private void OnTriggerEnter(Collider col)
    {
        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "PuzzleBlock1")
        {
            Container.GetComponent<CapsuleCollider>().enabled = false;
            Snap();
        }
    }

    void Snap()
    {
        GameObject puzzleBlockOne = GameObject.FindWithTag("PuzzleBlock1");
        puzzleBlockOne.transform.position = new Vector3(Container.transform.position.x, puzzleBlockOne.transform.position.y, Container.transform.position.z);
        puzzleBlockOne.GetComponent<Rigidbody>().isKinematic = true;
        puzzle1Solved = true;
    }
}
