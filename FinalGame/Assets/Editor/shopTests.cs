using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopTests : MonoBehaviour
{
    public int gold = 1000;
    ArrayList inventory = new ArrayList();

    public int buyItem(int itemPrice, string name)
    {
        if(gold >= itemPrice)
        {
            gold -= itemPrice;
            inventory.Add(name);
        }
        else
        {
            return gold;
        }

        return gold;
    }

    public string inventoryName(int slot)
    {
        string itemName;
        if (inventory[slot] == null)
        {
            itemName = "empty";
        }
        else
        {
            itemName = (string)inventory[slot];
        }
        
        return itemName;
    }
}
