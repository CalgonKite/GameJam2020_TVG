using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamHandler : MonoBehaviour
{
    //PROGRAMMED BT
    // LEE FEARNETT
    // JACK PROCTER

    //Camera
    public GameObject Cam;
    int currentCampoint;

    //gameobject campoints
    GameObject campoint0;
    GameObject campoint1;
    GameObject campoint2;
    GameObject campoint3;

    GameObject Focalpoint;

    public bool movement = false;

    // Start is called before the first frame update
    void Start()
    {
        currentCampoint = 0;
    }

    private void Awake()
    {
        //assign the object references
        campoint0 = GameObject.FindGameObjectWithTag("CamPoint1");
        campoint1 = GameObject.FindGameObjectWithTag("CamPoint2");
        campoint2 = GameObject.FindGameObjectWithTag("CamPoint3");
        campoint3 = GameObject.FindGameObjectWithTag("CamPoint4");
        Focalpoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }

    private void LateUpdate()
    {
        //if movement is false
        if (!movement)
        {
            //check inputs for forward and back
            if (Input.GetKeyDown("e"))
            {
                camRotateForward();
            }
            else if (Input.GetKeyDown("q"))
            {
                camRotateBackward();
            }
        }
    }

    //moves to camera forward
    IEnumerator movecameraNext(GameObject campoint)
    {
        //disable spamming keys
        movement = true;

        //while camera is not equal to margin of error keep moving to next point
        while (Cam.transform.position.x <= campoint.transform.position.x - 0.1 || Cam.transform.position.x >= campoint.transform.position.x + 0.1)
        {
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, campoint.transform.position, Time.deltaTime * 2);
            Cam.transform.LookAt(Focalpoint.transform.position);
            yield return null;
        }

        //changes campoints to correct place
        if (currentCampoint == 3)
        {
            currentCampoint = 0;
        }
        else if (currentCampoint == 2)
        {
            currentCampoint = 3;
        }
        else if (currentCampoint == 1)
        {
            currentCampoint = 2;
        }
        else if (currentCampoint == 0)
        {
            currentCampoint = 1;
        }

        movement = false;
    }

    IEnumerator movecameraPrev(GameObject campoint)
    {
        //disable spamming keys
        movement = true;

        //while camera is not equal to margin of error keep moving to next point
        while (Cam.transform.position.x <= campoint.transform.position.x - 0.1 || Cam.transform.position.x >= campoint.transform.position.x + 0.1)
        {
            Cam.transform.position = Vector3.Lerp(Cam.transform.position, campoint.transform.position, Time.deltaTime * 2);
            Cam.transform.LookAt(Focalpoint.transform.position);
            yield return null;
        }

        //changes campoints to correct place
        if (currentCampoint == 3)
        {
            currentCampoint = 2;
        }
        else if (currentCampoint == 2)
        {
            currentCampoint = 1;
        }
        else if (currentCampoint == 1)
        {
            currentCampoint = 0;
        }
        else if (currentCampoint == 0)
        {
            currentCampoint = 3;
        }

        Debug.Log(currentCampoint);

        movement = false;
    }

    void camRotateForward()
    {
        //GET CURRENT CAMERA POSITION
        switch (currentCampoint)
        {
            case 0:
                //Move camera
                StartCoroutine(movecameraNext(campoint1));
                break;
            case 1:
                StartCoroutine(movecameraNext(campoint2));
                break;
            case 2:
                StartCoroutine(movecameraNext(campoint3));
                break;
            case 3:
                StartCoroutine(movecameraNext(campoint0));
                break;
        }
    }

    void camRotateBackward()
    {
        //GET CURRENT CAMERA POSITION
        switch (currentCampoint)
        {
            //Move camera
            case 0:
                StartCoroutine(movecameraPrev(campoint3));
                break;
            case 1:
                StartCoroutine(movecameraPrev(campoint0));
                break;
            case 2:
                StartCoroutine(movecameraPrev(campoint1));
                break;
            case 3:
                StartCoroutine(movecameraPrev(campoint2));
                break;
        }
    }
}
