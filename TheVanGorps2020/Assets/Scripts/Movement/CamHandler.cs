using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHandler : MonoBehaviour
{
    //Camera
    public GameObject Cam;

    //List of campositions
    List<GameObject> Campositions = new List<GameObject>();

    //gameobject campoints
    GameObject campoint1;
    GameObject campoint2;
    GameObject campoint3;
    GameObject campoint4;

    // Start is called before the first frame update
    void Start()
    {
        //add all campositions to the list
        Campositions.Add(campoint1);
        Campositions.Add(campoint2);
        Campositions.Add(campoint3);
        Campositions.Add(campoint4);
    }

    private void Awake()
    {
        //assign the object references
        campoint1 = GameObject.FindGameObjectWithTag("CamPoint1");
        campoint2 = GameObject.FindGameObjectWithTag("CamPoint2");
        campoint3 = GameObject.FindGameObjectWithTag("CamPoint3");
        campoint4 = GameObject.FindGameObjectWithTag("CamPoint4");
    }

    private void FixedUpdate()
    {

        if (Input.GetKey("Q"))
        {
            camRotateForward();
        }
        else if (Input.GetKey("E"))
        {
            camRotateBackward();
        }
    }

    void camRotateForward()
    {
        //GET CURRENT CAMERA POSITION


        //Cam.transform.Translate(campoint2.transform.position);
    }

    void camRotateBackward()
    {

    }
}
