using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleContainer3 : MonoBehaviour
{
    //Programed by Lee Fearnett
    public bool puzzle3Solved = false;
    public GameObject Container;

    private void OnTriggerEnter(Collider col)
    {}

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "PuzzleBlock3")
        {
            Container.GetComponent<CapsuleCollider>().enabled = false;
            Snap();
        }
    }

    void Snap()
    {
        GameObject puzzleBlockThree = GameObject.FindWithTag("PuzzleBlock3");
        puzzleBlockThree.transform.position = new Vector3(Container.transform.position.x, puzzleBlockThree.transform.position.y, Container.transform.position.z);
        puzzleBlockThree.GetComponent<Rigidbody>().isKinematic = true;
        puzzle3Solved = true;
    }
}
