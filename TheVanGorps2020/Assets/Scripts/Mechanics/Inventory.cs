using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    // Programmed by JP //
    [HideInInspector]
    public List<Item> Items = new List<Item>();
    [HideInInspector]
    public List<Item> CurrentItem = new List<Item>();
    public GameObject Cog1, Cog2, Cog3;

    private void Start()
    {
        ConstructInventory();

        //AddItem(0);
    }

    public void AddItem(int ID)
    {
        CurrentItem.Add(Items[ID]); 
    }

    public void DropItem()
    {
        if (CurrentItem.Count > 0)
        {
            Vector3 Spawn = new Vector3(this.transform.position.x + 1.5f, this.transform.position.y, this.transform.position.z);
            Instantiate(CurrentItem[0].itemPrefab, Spawn, Quaternion.identity);
            CurrentItem.Remove(CurrentItem[0]);
        }
    }   

    void ConstructInventory()
    {
        Items = new List<Item>(){
            new Item("Cog", 0, Cog1),
            new Item("Smol Cog", 1, Cog2),
            new Item("Chonk Cog", 2, Cog3),
        };
    }

    private void Update()
    {
        if (CurrentItem.Count > 0)
        {
            Debug.Log(CurrentItem[0].iName);
        }
        if (Input.GetKeyDown("g"))
        {
            DropItem();
        }
    }
}