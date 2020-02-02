using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogHolder1 : MonoBehaviour
{

    //PROGRAMMED BY
    //LEE FEARNETT
    //JACK PROCTER

    public Inventory invent;
    public Inventory cogHoldInvent;
    public bool cogplace = false;
    public bool cogtake = false;
    public bool correctcog = false;
    public int cogNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        invent = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        cogHoldInvent = this.GetComponent<Inventory>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(cogHoldInvent.CurrentItem.Count > 0)
        {
            Debug.Log(cogHoldInvent.CurrentItem[0].iD);
        }
        if(cogHoldInvent.CurrentItem.Count == 0)
        {
            Debug.Log("NO COG IN MACHINE");
        }

        
    }

    private void LateUpdate()
    {
        if (cogtake == true)
        {
            cogtake = false;
            takeCog(); //working
        }
        else if (cogplace == true)
        {
            cogplace = false;
            placeCog(); //working
        }
        else { }
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            if (Input.GetKeyDown("f"))
            {
                if (cogHoldInvent.CurrentItem.Count == 1)
                {
                    cogtake = true;
                }
                else
                {
                    cogplace = true;
                }
            }
        }
    }

    void takeCog()
    {
        if(invent.CurrentItem.Count > 0) // Checks if the player is carrying a cog //
        {
            Debug.Log("Player inventory full"); // Debug message //
        }
        else if(invent.CurrentItem.Count == 0) // If the player isn't carrying a cog //
        {
            invent.AddItem(cogHoldInvent.CurrentItem[0].iD); // Give the player the cog //
            cogHoldInvent.CurrentItem.Remove(cogHoldInvent.CurrentItem[0]);//
            Debug.Log("CogTaken");
            correctcog = false;
        }
    }

    void placeCog()
    {
        if(invent.CurrentItem.Count > 0) // Checks if the player is carrying a cog //
        {
            cogHoldInvent.AddItem(invent.CurrentItem[0].iD);
            invent.CurrentItem.Remove(invent.CurrentItem[0]); //
            if(cogHoldInvent.CurrentItem[0].iD == cogNum)
            {
                Debug.Log("Good job");
                correctcog = true;
            }
        }
        else if (invent.CurrentItem.Count == 0) // If the player isn't carrying a cog //
        {
            Debug.Log("Player inventory empty"); // Debug message //
        }
    }
}
