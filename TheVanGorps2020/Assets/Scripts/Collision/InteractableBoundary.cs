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
        Debug.Log("Entered " + name);
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
        Debug.Log("Left " + name);
    }
}
