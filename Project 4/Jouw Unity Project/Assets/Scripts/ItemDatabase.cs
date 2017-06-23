using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour
{
    public List<Item> InventoryDat = new List<Item>();


    void Start()
    {
        foreach (Item i in InventoryDat)
        {
            i.itemAmount = PlayerPrefs.GetInt(i.itemName);
        }
    }

    void FixedUpdate()
    {
        foreach (Item i in InventoryDat)
        {
            i.itemAmountT.text = ""+i.itemAmount;

            if (i.itemAmount !=PlayerPrefs.GetInt(i.itemName))
            {
                PlayerPrefs.SetInt(i.itemName, i.itemAmount);
                print("saved: "+i.itemName);
            }
        }
    }
}
