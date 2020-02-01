using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextFloor1 : MonoBehaviour
{
    GameObject player;

    // ASSIGN THIS EVERY LEVEL
    public GameObject floor2;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            NextFloor();
        }
    }

    void NextFloor()
    {
        floor2.SetActive(true);
        GameObject manager = GameObject.FindGameObjectWithTag("Play&Cam");
        GameObject spawn2 = GameObject.FindGameObjectWithTag("Spawn2");
        manager.transform.position = new Vector3(manager.transform.position.x, spawn2.transform.position.y, manager.transform.position.z);
        player.transform.position = spawn2.transform.position;

    }
}
