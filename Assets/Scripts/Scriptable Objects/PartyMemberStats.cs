using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PartyMemberStats", menuName = "ScriptableObjects/PartyMemberStats", order = 1)]
public class PartyMemberStats : ScriptableObject
{
    private int attack;
    private int defense;

    public Sprite sprite;

    public List<Skills> skill = new List<Skills>();
}
