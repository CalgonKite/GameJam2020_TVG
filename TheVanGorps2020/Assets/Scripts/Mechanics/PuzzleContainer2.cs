using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleContainer2 : MonoBehaviour
{
    //Programed by Lee Fearnett
    public bool puzzle2Solved = false;
    public GameObject Container;

    private void OnTriggerEnter(Collider col)
    {

    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "PuzzleBlock2")
        {
            Container.GetComponent<CapsuleCollider>().enabled = false;
            Snap();
        }
    }

    void Snap()
    {
        GameObject puzzleBlockTwo = GameObject.FindWithTag("PuzzleBlock2");
        puzzleBlockTwo.transform.position = new Vector3(Container.transform.position.x, puzzleBlockTwo.transform.position.y, Container.transform.position.z);
        puzzleBlockTwo.GetComponent<Rigidbody>().isKinematic = true;
        puzzle2Solved = true;
    }
}
