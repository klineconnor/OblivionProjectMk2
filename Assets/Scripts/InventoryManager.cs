using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    Hashtable items = new Hashtable();

    public void addItem(Item newItem)
    {
        if (items.ContainsKey(newItem.name))
        {
            ((Item)items[newItem.name]).AddAmount(newItem.Amount);
        } else
        {
            items.Add(newItem.name, newItem);
        }
    }

    public Hashtable GetItems()
    {
        return items;
    }
}
