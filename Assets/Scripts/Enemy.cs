using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private EnemyStats stats;

   public void setStats(EnemyStats stats)
    {
        this.stats = stats;
    }
}
