﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableBoundary : MonoBehaviour
{
    /// <summary>
    /// Name of the bound being triggered
    /// </summary>
    private string Name;
    /// <summary>
    /// The main camera of the scene
    /// </summary>
    public GameObject Camera;
    /// <summary>
    /// The default camera position for the menu scene
    /// </summary>
    public GameObject DefaultCamera;
    /// <summary>
    /// The settings camera position for the menu scene
    /// </summary>
    public GameObject SettingsCamera;
    /// <summary>
    /// The levels camera position for the menu scene
    /// </summary>
    public GameObject LevelsCamera;
    /// <summary>
    /// The focal point (center) for camera positioning
    /// </summary>
    public GameObject FocalPoint;

    /// <summary>
    /// Trigger area for play button
    /// </summary>
    public GameObject boundPlay;
    /// <summary>
    /// Trigger area for Settings
    /// </summary>
    public GameObject boundSettings;
    /// <summary>
    /// Trigger area for levels
    /// </summary>
    public GameObject boundExit;

    /// <summary>
    /// Trigger area for audio level adjustments
    /// </summary>
    public GameObject boundAudioLevel;
    /// <summary>
    /// Trigger area for timer display
    /// </summary>
    public GameObject boundTimer;
    /// <summary>
    /// Trigger area for Returning to main menu
    /// </summary>
    public GameObject boundSettingsReturn;

    /// <summary>
    /// Trigger area for returning to main menu area
    /// </summary>
    public GameObject boundLevelsReturn;
    /// <summary>
    /// Trigger area for beginning level 1
    /// </summary>
    public GameObject boundLevel1;
    /// <summary>
    /// Trigger area for beginning level 2
    /// </summary>
    public GameObject boundLevel2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Called when trigger start event occurs against player object.
    /// Also shows the label object for the colliding object.
    /// </summary>
    /// <param name="other">The information of the object colliding with the player object</param>
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

            case "boundAudioLevel":
                buttonLabel = GameObject.Find("audioLevelButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundTimer":
                buttonLabel = GameObject.Find("timerButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundSettingsReturn":
                buttonLabel = GameObject.Find("settingsReturnButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundLevelsReturn":
                buttonLabel = GameObject.Find("levelsReturnButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundLevel1":
                buttonLabel = GameObject.Find("level1ButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;

            case "boundLevel2":
                buttonLabel = GameObject.Find("level2ButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = true;
                break;
        }
        
    }
    /// <summary>
    /// Handling events while the player stays within a trigger box.
    /// When the player presses the action button the specific event for the current bound box is completed.
    /// Some trigger boxes complete specific actions, while others simply move the camera to a different position.
    /// When camera moves, trigger boxes are enabled and disabled depending on the current camera position.
    /// </summary>
    /// <param name="other">The object colliding with the player object</param>
    /// <returns></returns>
    private IEnumerator OnTriggerStay(Collider other)
    {
        bool keyPressed = Input.GetKeyDown(KeyCode.L);
        if(keyPressed)
        {
            Debug.Log("test");
            switch(name)
            {
                case "boundPlay":
                    Debug.Log(LevelsCamera.name);
                    while (Camera.transform.position.x <= LevelsCamera.transform.position.x - 0.1 || Camera.transform.position.x >= LevelsCamera.transform.position.x + 0.1)
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, LevelsCamera.transform.position, Time.deltaTime);
                        Camera.transform.LookAt(FocalPoint.transform.position);
                        yield return null;
                    }
                    boundPlay.GetComponent<BoxCollider>().enabled = false;
                    boundSettings.GetComponent<BoxCollider>().enabled = false;
                    boundExit.GetComponent<BoxCollider>().enabled = false;

                    boundAudioLevel.GetComponent<BoxCollider>().enabled = false;
                    boundTimer.GetComponent<BoxCollider>().enabled = false;
                    boundSettingsReturn.GetComponent<BoxCollider>().enabled = false;

                    boundLevelsReturn.GetComponent<BoxCollider>().enabled = true;
                    boundLevel1.GetComponent<BoxCollider>().enabled = true;
                    boundLevel2.GetComponent<BoxCollider>().enabled = true;
                    break;

                case "boundSetting":
                    Debug.Log(SettingsCamera.name);
                    while (Camera.transform.position.x <= SettingsCamera.transform.position.x - 0.1 || Camera.transform.position.x >= SettingsCamera.transform.position.x + 0.1)
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, SettingsCamera.transform.position, Time.deltaTime);
                        Camera.transform.LookAt(FocalPoint.transform.position);
                        yield return null;
                    }
                    boundPlay.GetComponent<BoxCollider>().enabled = false;
                    boundSettings.GetComponent<BoxCollider>().enabled = false;
                    boundExit.GetComponent<BoxCollider>().enabled = false;

                    boundAudioLevel.GetComponent<BoxCollider>().enabled = true;
                    boundTimer.GetComponent<BoxCollider>().enabled = true;
                    boundSettingsReturn.GetComponent<BoxCollider>().enabled = true;

                    boundLevelsReturn.GetComponent<BoxCollider>().enabled = false;
                    boundLevel1.GetComponent<BoxCollider>().enabled = false;
                    boundLevel2.GetComponent<BoxCollider>().enabled = false;
                    break;

                case "boundExit":
                    Debug.Log("Hit button in exit");
                    Application.Quit();
                    break;

                case "boundAudioLevel":
                    Debug.Log("Audio Level Changing");
                    break;

                case "boundTimer":
                    Debug.Log("Sets timer setting");
                    break;

                case "boundSettingsReturn":
                    Debug.Log("Return to Default Camera :)");
                    while (Camera.transform.position.x <= DefaultCamera.transform.position.x - 0.1 || Camera.transform.position.x >= DefaultCamera.transform.position.x + 0.1)
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, DefaultCamera.transform.position, Time.deltaTime);
                        Camera.transform.LookAt(FocalPoint.transform.position);
                        yield return null;
                    }

                    boundPlay.GetComponent<BoxCollider>().enabled = true;
                    boundSettings.GetComponent<BoxCollider>().enabled = true;
                    boundExit.GetComponent<BoxCollider>().enabled = true;

                    boundAudioLevel.GetComponent<BoxCollider>().enabled = false;
                    boundTimer.GetComponent<BoxCollider>().enabled = false;
                    boundSettingsReturn.GetComponent<BoxCollider>().enabled = false;

                    boundLevelsReturn.GetComponent<BoxCollider>().enabled = false;
                    boundLevel1.GetComponent<BoxCollider>().enabled = false;
                    boundLevel2.GetComponent<BoxCollider>().enabled = false;

                    break;

                case "boundLevelsReturn":
                    Debug.Log("Move back to default camera");
                    while (Camera.transform.position.x <= DefaultCamera.transform.position.x - 0.1 || Camera.transform.position.x >= DefaultCamera.transform.position.x + 0.1)
                    {
                        Camera.transform.position = Vector3.Lerp(Camera.transform.position, DefaultCamera.transform.position, Time.deltaTime);
                        Camera.transform.LookAt(FocalPoint.transform.position);
                        yield return null;
                    }
                    boundPlay.GetComponent<BoxCollider>().enabled = true;
                    boundSettings.GetComponent<BoxCollider>().enabled = true;
                    boundExit.GetComponent<BoxCollider>().enabled = true;

                    boundAudioLevel.GetComponent<BoxCollider>().enabled = false;
                    boundTimer.GetComponent<BoxCollider>().enabled = false;
                    boundSettingsReturn.GetComponent<BoxCollider>().enabled = false;

                    boundLevelsReturn.GetComponent<BoxCollider>().enabled = false;
                    boundLevel1.GetComponent<BoxCollider>().enabled = false;
                    boundLevel2.GetComponent<BoxCollider>().enabled = false;
                    break;

                case "boundLevel1":
                    SceneManager.LoadScene(1);
                    Debug.Log("Start Level 1");
                    break;

                case "boundLevel2":
                    Debug.Log("Start level 2");
                    break;
            }
        }
    }
    /// <summary>
    /// Handles when player object leaves the bounding box.
    /// This involves hiding the button label for the correct label object, that is linked with the bound box.
    /// </summary>
    /// <param name="other">The object colliding with the player object</param>
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

            case "boundAudioLevel":
                buttonLabel = GameObject.Find("audioLevelButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundTimer":
                buttonLabel = GameObject.Find("timerButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundSettingsReturn":
                buttonLabel = GameObject.Find("settingsReturnButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundLevelsReturn":
                buttonLabel = GameObject.Find("levelsReturnButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundLevel1":
                buttonLabel = GameObject.Find("level1ButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;

            case "boundLevel2":
                buttonLabel = GameObject.Find("level2ButtonLabel");
                buttonLabel.GetComponent<Renderer>().enabled = false;
                break;
        }
    }
}
