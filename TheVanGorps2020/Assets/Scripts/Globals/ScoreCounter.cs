using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text timerText;
    /// <summary>
    /// This script just needs to be applied to an object in each scene and can then be accessed.
    /// </summary>
    static float GlobalTimer;
    int rounded_timer;


    void Start()
    {
        //timerText.text = GlobalTimer.ToString();

    }


    void Update()
    {
        GlobalTimer += 1 * Time.deltaTime;
        rounded_timer = (int)(GlobalTimer+0.5f);
        Debug.Log(rounded_timer);
        timerText.text = rounded_timer.ToString();
    }
}
