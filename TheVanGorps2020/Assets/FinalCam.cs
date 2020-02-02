using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalCam : MonoBehaviour
{
    //Camera
    public GameObject Cam;
    public GameObject camChild;
    int currentCampoint;

    //gameobject campoints
    GameObject campoint0;
    GameObject campoint1;
    GameObject campoint2;
    GameObject campoint3;

    public GameObject Focalpoint;

    public bool movement = false;
    public bool destinationReached = true;
    // Start is called before the first frame update
    void Start()
    {
        currentCampoint = 0;
    }

    private void Awake()
    {
        //assign the object references
        findcamPos();
    }

    private void LateUpdate()
    {
        //if movement is false
        if (!movement)
        {
            //check inputs for forward and back
            if (destinationReached == true)
            {
                destinationReached = false;
                camRotateForward();
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
            camChild.transform.localEulerAngles = new Vector3(-22.154f, 0f, 0f);
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

        destinationReached = true;

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

    void findcamPos()
    {
        campoint0 = GameObject.FindGameObjectWithTag("CamPoint1");
        campoint1 = GameObject.FindGameObjectWithTag("CamPoint2");
        campoint2 = GameObject.FindGameObjectWithTag("CamPoint3");
        campoint3 = GameObject.FindGameObjectWithTag("CamPoint4");
        Focalpoint = GameObject.FindGameObjectWithTag("FocalPoint");
    }
}
