using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{

    private int amount;

    public int Amount { get => amount; set => amount = value; }

    public Item(string name, int amount)
    {
        this.name = name;
        this.amount = amount;
    }

    public void AddAmount( int amount)
    {
        this.amount += amount;
    }
}
