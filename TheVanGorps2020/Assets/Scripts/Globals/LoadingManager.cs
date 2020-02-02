using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{

    //PROGRAMMED BY LEE FEARNETT

    AsyncOperation operation;
    int Index;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            StartCoroutine(loadAsync());
        }
    }

    IEnumerator loadAsync()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        switch (currentSceneName)
        {
            case "Tutorial1": Index = 2; break;
            case "Tutorial2": Index = 3; break;

            case "Level1": Index = 4; break;
            case "Level2": Index = 5; break;
            case "Level3": Index = 6; break;
            case "level4": Index = 6; break; //REPEAT LEVEL FIX LATER
        }

        operation = SceneManager.LoadSceneAsync(Index);

        //loadingScreen.active = true;

        while (!operation.isDone)
        {
            Debug.Log("LOADING");
            yield return null;
        }

        if (operation.isDone)
        {
            Debug.Log(operation.progress);
            Debug.Log("THE SCENE IS DEFINITELY LOADED");
            //loadingScreen.active = false;
        }
    }

    void NextLevelSelect()
    {
    }
}
