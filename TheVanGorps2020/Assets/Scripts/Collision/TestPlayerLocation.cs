using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerLocation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        
        if (col.tag == "Player")
        {
            Debug.Log("test");
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            Vector3 test = new Vector3(player.transform.position.x - 100, player.transform.position.y, player.transform.position.z);
            player.transform.position = test;
        }
    }

    void NextFloor()
    {
        

    }
}
