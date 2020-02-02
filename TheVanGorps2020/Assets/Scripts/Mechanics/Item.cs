using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Programmed by JP //

    public string iName; // Name of the item //
    public int iD; // ID of the given item //
    public GameObject itemPrefab; // GameObject //
    public Sprite Icon; // Icon used to represent each item //

    public Item(string iName, int iD, GameObject itemPrefab, Sprite Icon)
    {
        this.iName = iName;
        this.iD = iD;
        this.itemPrefab = itemPrefab;
        this.Icon = Icon;
    }
}
