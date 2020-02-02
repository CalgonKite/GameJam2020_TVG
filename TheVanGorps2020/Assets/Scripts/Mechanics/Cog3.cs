using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cog3 : MonoBehaviour
{
    // Programmed by JP & LF //

    public Inventory Invent;
    int PickupID = 2;

    // Start is called before the first frame update
    void Start()
    {
        Invent = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); // Access to Inventory //
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
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

    void AddToInventory()
    {
        Invent.AddItem(PickupID);
        Destroy(this.gameObject);
    }
}