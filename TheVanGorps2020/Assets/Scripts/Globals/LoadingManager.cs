using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{

    //PROGRAMMED BY LEE FEARNETT

    AsyncOperation operation;
    int Index;

    private void LateUpdate()
    {
        if (Input.GetKeyDown("r")) { StartCoroutine(reload()); }
    }

    private void OnTriggerEnter(Collider col)
    {
        //if walk into next level object tag
        if (col.tag == "Player")
        {
            StartCoroutine(loadAsync());
        }
    }

    //LOADS
    IEnumerator loadAsync()
    {
        //grabs loading screen and active scene name
        string currentSceneName = SceneManager.GetActiveScene().name;

        GameObject loadingScreen = GameObject.FindGameObjectWithTag("LoadScreen");

        //assigns index based on scene name
        switch (currentSceneName)
        {
            case "Tutorial1": Index = 2; break;
            case "Tutorial2": Index = 3; break;

            case "Level1": Index = 4; break;
            case "Level2": Index = 5; break;
            case "Level3": Index = 6; break;
            case "level4": Index = 6; break; //REPEAT LEVEL FIX LATER
        }

        //manual wait before load
        StartCoroutine(loadscreen(loadingScreen));

        //Load
        operation = SceneManager.LoadSceneAsync(Index);

        //loadingScreen.active = true;

        //wait till operation finishes
        while (!operation.isDone)
        {
            Debug.Log("LOADING");
            yield return null;
        }

        //do stuff when operation finishes
        if (operation.isDone)
        {
            Debug.Log(operation.progress);
            Debug.Log("THE SCENE IS DEFINITELY LOADED");
            loadingScreen.active = false;
        }
    }

    IEnumerator loadscreen (GameObject loadingScreen)
    {
        loadingScreen.active = true;
        yield return new WaitForSecondsRealtime(2);
    }

    IEnumerator reload()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        GameObject loadingScreen = GameObject.FindGameObjectWithTag("LoadScreen");

        StartCoroutine(loadscreen(loadingScreen));

        operation = SceneManager.LoadSceneAsync(currentSceneName);

        //wait till operation finishes
        while (!operation.isDone)
        {
            Debug.Log("LOADING");
            yield return null;
        }


        //do stuff when operation finishes
        if (operation.isDone)
        {
            Debug.Log(operation.progress);
            Debug.Log("THE SCENE IS DEFINITELY LOADED");
            loadingScreen.active = false;
        }
    }
}
