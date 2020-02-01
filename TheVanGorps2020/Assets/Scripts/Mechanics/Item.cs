﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // Programmed by JP //

    public string iName; // Name of the item //
    public int iD; // ID of the given item //
    public GameObject itemPrefab; // GameObject //

    public Item(string iName, int iD, GameObject itemPrefab)
    {
        this.iName = iName;
        this.iD = iD;
        this.itemPrefab = itemPrefab;
    }
}