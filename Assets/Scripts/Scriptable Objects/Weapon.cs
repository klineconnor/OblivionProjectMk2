using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    private int attack;

    public Weapon(string name, int amount, int attack) : base(name, amount)
    {
        this.attack = attack;
    }

    public int Attack { get => attack; set => attack = value; }
}
