using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public Text timerText;
    /// <summary>
    /// This script just needs to be applied to an object in each scene and can then be accessed.
    /// </summary>
    static float GlobalTimer;
    public int rounded_timer;
    Scene scene;

    void Start()
    {
        //timerText.text = GlobalTimer.ToString();
        scene = SceneManager.GetActiveScene();
    }


    void Update()
    {
        if (scene.name != "MenuScene")
        {
            GlobalTimer += 1 * Time.deltaTime;
            rounded_timer = (int)(GlobalTimer + 0.5f);
            //Debug.Log(rounded_timer);
            timerText.text = rounded_timer.ToString();
        }
        else
        {
            return;
        }
    }
}
