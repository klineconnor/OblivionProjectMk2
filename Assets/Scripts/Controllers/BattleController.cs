using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : MonoBehaviour
{
    public PartyMemberStats partyMember1, partyMember2, partyMember3, partyMember4;

    public EnemyStats enemy1, enemy2, enemy3, enemy4;

    public Vector2 partyMemberPosition1, partyMemberPosition2, partyMemberPosition3, partyMemberPosition4, enemyPosition1, enemyPosition2, enemyPosition3, enemyPosition4;

    public GameObject partyMember1Object;
    public GameObject partyMember2Object;
    public GameObject partyMember3Object;
    public GameObject partyMember4Object;

    private void SpawnPlayers()
    {
        if (partyMember1 != null)
        {
            partyMember1Object = new GameObject("partyMember1");
            partyMember1Object.AddComponent<PartyMember>();
            partyMember1Object.GetComponent<PartyMember>().setStats(partyMember1);
            partyMember1Object.AddComponent<SpriteRenderer>();
            partyMember1Object.GetComponent<SpriteRenderer>().sprite = partyMember1.sprite;
            partyMember1Object.transform.position = partyMemberPosition1;
        }
        if (partyMember2 != null)
        {
            partyMember2Object = new GameObject("partyMember2");
            partyMember2Object.AddComponent<PartyMember>();
            partyMember2Object.GetComponent<PartyMember>().setStats(partyMember2);
            partyMember2Object.AddComponent<SpriteRenderer>();
            partyMember2Object.GetComponent<SpriteRenderer>().sprite = partyMember2.sprite;
            partyMember2Object.transform.position = partyMemberPosition2;
        }
        if (partyMember3 != null)
        {
            partyMember3Object = new GameObject("partyMember3");
            partyMember3Object.AddComponent<PartyMember>();
            partyMember3Object.GetComponent<PartyMember>().setStats(partyMember3);
            partyMember3Object.AddComponent<SpriteRenderer>();
            partyMember3Object.GetComponent<SpriteRenderer>().sprite = partyMember3.sprite;
            partyMember3Object.transform.position = partyMemberPosition3;
        }
        if (partyMember4 != null)
        {
            partyMember4Object = new GameObject("partyMember4");
            partyMember4Object.AddComponent<PartyMember>();
            partyMember4Object.GetComponent<PartyMember>().setStats(partyMember4);
            partyMember4Object.AddComponent<SpriteRenderer>();
            partyMember4Object.GetComponent<SpriteRenderer>().sprite = partyMember4.sprite;
            partyMember4Object.transform.position = partyMemberPosition4;
        }
    }

    private void SpawnEnemies()
    {
        if (enemy1 != null)
        {
            GameObject enemy1Object = new GameObject("enemy1");
            enemy1Object.AddComponent<Enemy>();
            enemy1Object.GetComponent<Enemy>().setStats(enemy1);
            enemy1Object.AddComponent<SpriteRenderer>();
            enemy1Object.GetComponent<SpriteRenderer>().sprite = enemy1.sprite;
            enemy1Object.transform.position = enemyPosition1;
        }
        if (enemy2 != null)
        {
            GameObject enemy2Object = new GameObject("enemy2");
            enemy2Object.AddComponent<Enemy>();
            enemy2Object.GetComponent<Enemy>().setStats(enemy2);
            enemy2Object.AddComponent<SpriteRenderer>();
            enemy2Object.GetComponent<SpriteRenderer>().sprite = enemy2.sprite;
            enemy2Object.transform.position = enemyPosition2;
        }
        if (enemy3 != null)
        {
            GameObject enemy3Object = new GameObject("enemy3");
            enemy3Object.AddComponent<Enemy>();
            enemy3Object.GetComponent<Enemy>().setStats(enemy3);
            enemy3Object.AddComponent<SpriteRenderer>();
            enemy3Object.GetComponent<SpriteRenderer>().sprite = enemy3.sprite;
            enemy3Object.transform.position = enemyPosition3;
        }
        if (enemy4 != null)
        {
            GameObject enemy4Object = new GameObject("enemy4");
            enemy4Object.AddComponent<Enemy>();
            enemy4Object.GetComponent<Enemy>().setStats(enemy4);
            enemy4Object.AddComponent<SpriteRenderer>();
            enemy4Object.GetComponent<SpriteRenderer>().sprite = enemy4.sprite;
            enemy4Object.transform.position = enemyPosition4;
        }
    }

    public void SetPartyMember(PartyMemberStats partyMember1)
    {
        this.partyMember1 = partyMember1;
    }

    public void SetPartyMember(PartyMemberStats partyMember1, PartyMemberStats partyMember2)
    {
        this.partyMember1 = partyMember1;
        this.partyMember2 = partyMember2;
    }

    public void SetPartyMember(PartyMemberStats partyMember1, PartyMemberStats partyMember2, PartyMemberStats partyMember3)
    {
        this.partyMember1 = partyMember1;
        this.partyMember2 = partyMember2;
        this.partyMember3 = partyMember3;
    }

    public void SetPartyMember(PartyMemberStats partyMember1, PartyMemberStats partyMember2, PartyMemberStats partyMember3, PartyMemberStats partyMember4)
    {
        this.partyMember1 = partyMember1;
        this.partyMember2 = partyMember2;
        this.partyMember3 = partyMember3;
        this.partyMember4 = partyMember4;
    }

    public void SetEnemies()
    {
        if (BattleData.enemy1 != null)
        {
            Debug.Log("Does this run");
            enemy1 = BattleData.enemy1;
        }
        if (BattleData.enemy1 != null)
        {
            enemy2 = BattleData.enemy2;
        }
        if (BattleData.enemy1 != null)
        {
            enemy3 = BattleData.enemy3;
        }
        if (BattleData.enemy1 != null)
        {
            enemy4 = BattleData.enemy4;
        }
    }

    private void Start()
    {
        SetEnemies();
        SpawnPlayers();
        SpawnEnemies();
    }

}
