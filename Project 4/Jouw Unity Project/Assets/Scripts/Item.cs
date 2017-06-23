using System.Collections;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public int itemAmount;
    public GameObject itemSlot;
    public Text itemAmountT;

    public Item(string iName, int iAmount, GameObject iSlot, Text iAmountT)
    {
        iName = itemName;
        iAmount = itemAmount;
        iSlot = itemSlot;
        iAmountT.text = "" + itemAmountT;
    }
}
