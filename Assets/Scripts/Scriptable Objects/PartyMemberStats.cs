using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PartyMemberStats", menuName = "ScriptableObjects/PartyMemberStats", order = 1)]
public class PartyMemberStats : ScriptableObject
{
    public int attack;
    public int defense;

    public int speed;

    public Sprite sprite;

    public List<Skills> skill = new List<Skills>();

    public void RunAttack()
    {
        
    }
}
