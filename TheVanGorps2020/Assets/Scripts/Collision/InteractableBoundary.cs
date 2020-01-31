using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableBoundary : MonoBehaviour
{
    private string name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        name = other.name;
        GameObject buttonLabel;
        switch (name)
        {
            case "boundPlay":
                buttonLabel = GameObject.Find("playButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundSetting":
                buttonLabel = GameObject.Find("settingsButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundExit":
                buttonLabel = GameObject.Find("exitButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;
        }
        
    }
    private void OnTriggerStay(Collider other)
    {
        bool keyPressed = Input.GetKeyDown(KeyCode.E);
        if(keyPressed)
        {
            switch(name)
            {
                case "boundPlay":
                    Debug.Log("Hit button in play");

                    break;

                case "boundSetting":
                    Debug.Log("Hit button in play");
                    break;

                case "boundExit":
                    Debug.Log("Hit button in play");
                    break;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        GameObject buttonLabel;
        switch (name)
        {
            case "boundPlay":
                buttonLabel = GameObject.Find("playButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundSetting":
                buttonLabel = GameObject.Find("settingsButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundExit":
                buttonLabel = GameObject.Find("exitButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;
        }
    }
}
