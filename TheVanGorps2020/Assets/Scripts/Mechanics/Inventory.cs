using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    // Programmed by JP //
    [HideInInspector]
    public List<Item> Items = new List<Item>();

    public List<Item> CurrentItem = new List<Item>();
    public GameObject Cog1, Cog2, Cog3;
    public Sprite c1Icon, c2Icon, c3Icon;

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
            new Item("Cog", 0, Cog1, c1Icon),
            new Item("Smol Cog", 1, Cog2, c2Icon),
            new Item("Chonk Cog", 2, Cog3, c3Icon),
        };
    }

    private void Update()
    {
        if (CurrentItem.Count > 0)
        {
            Debug.Log(CurrentItem[0].iName);
        }

    }
}