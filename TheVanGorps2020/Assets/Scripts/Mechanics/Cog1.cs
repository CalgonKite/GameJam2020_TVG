using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog1 : MonoBehaviour
{
    // Programmed by JP & LF //

    public Inventory Invent;
    int PickupID = 0;
    public GameObject returnPoint;

    // Start is called before the first frame update
    void Start()
    {
        Invent = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); // Access to Inventory //
        returnPoint = GameObject.Find("C1returnPoint");
    }

    private void OnTriggerStay(Collider col)
    {
        if(col.tag == "Player")
        {
            if (Invent.CurrentItem.Count < 1)
            {
                AddToInventory();
            }
            else
            {
                Debug.Log("Inventory Full, press SPACEBAR to switch");
                if (Input.GetKeyDown("space"))
                {
                    Invent.DropItem();
                }
            }
        }
    }

    // DEBUG TO RETURN GAMEOBJECT //
    private void LateUpdate()
    {
        if (Input.GetKeyDown("p"))
        {
            this.gameObject.transform.position = returnPoint.transform.position;
        }
    }

    void AddToInventory()
    {
        Invent.AddItem(PickupID);
        Destroy(this.gameObject);
    }
}