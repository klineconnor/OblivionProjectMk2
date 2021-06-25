using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "ScriptableObjects/Enemy", order = 1)]
public class EnemyStats : ScriptableObject
{
    public int enemyAttack, health, speed;

    public Sprite sprite;

    public List<Skills> skills = new List<Skills>();

    public void RunAttack()
    {

    }

}
