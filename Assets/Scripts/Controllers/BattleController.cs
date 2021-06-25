using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BattleController : MonoBehaviour
{
    private int previousScene;
    public PartyMemberStats[] partyMembers;

    public EnemyStats[] enemies;

    public Vector2[] partyMemberPositions;
    public Vector2[] enemyPositions;

    public GameObject[] partyMemberObjects;

    public GameObject[] enemyObjects;

    private void SpawnPlayers()
    {
        int n = partyMembers.Length;
        for (int i = 0; i < n; i++)
        {
            partyMemberObjects[i] = new GameObject("partyMember" + i);
            partyMemberObjects[i].AddComponent<PartyMember>();
            partyMemberObjects[i].GetComponent<PartyMember>().setStats(partyMembers[i]);
            partyMemberObjects[i].AddComponent<SpriteRenderer>();
            partyMemberObjects[i].GetComponent<SpriteRenderer>().sprite = partyMembers[i].sprite;
            partyMemberObjects[i].transform.position = partyMemberPositions[i];
        }
        
    }

    private void SpawnEnemies()
    {
        int n = enemies.Length;
        for (int i = 0; i < n; i++)
        {
            enemyObjects[i] = new GameObject("enemy" + i);
            enemyObjects[i].AddComponent<Enemy>();
            enemyObjects[i].GetComponent<Enemy>().setStats(enemies[i]);
            enemyObjects[i].AddComponent<SpriteRenderer>();
            enemyObjects[i].GetComponent<SpriteRenderer>().sprite = enemies[0].sprite;
            enemyObjects[i].transform.position = enemyPositions[i];
        }
    }

    public void SetPartyMember(PartyMemberStats[] newPartyMembers)
    {
        int n = newPartyMembers.Length;
        for (int i = 0; i < n; i++)
        {
            partyMembers[i] = newPartyMembers[i];
        }
    }

    public void SetEnemies()
    {
        int n = BattleData.enemies.Length;
        for (int i = 0; i < n; i++)
        {
            enemies[i] = BattleData.enemies[i];
        }
    }

    private void Start()
    {
        previousScene = BattleData.previousScene;
        SetEnemies();
        SpawnPlayers();
        SpawnEnemies();
        currentState = BattleState.Player;
    }

    public enum BattleState {Player, Enemy, Run};
    private BattleState currentState;

    private void Update() 
    {
        if (currentState == BattleState.Player)
        {
            PlayerTurn();
        }
        if (currentState == BattleState.Enemy)
        {
            EnemyTurn();
        }
        if (currentState == BattleState.Run)
        {
            LoadingData.setSceneToLoad(previousScene);
            SceneManager.LoadScene(1);
        }
    }

    public void setTurnState(BattleState currentState)
    {
        this.currentState = currentState;
    }
    
    private void PlayerTurn()
    {
        if (partyMembers.Length > 1) {
             PartyMemberStats[] sortedParty = partyMembers;
            int n = sortedParty.Length;
            for (int i = 0; i<n; i++)
            {
                int min_ind = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (sortedParty[j].speed < sortedParty[i].speed)
                    {
                        min_ind = j;
                    }
                }
                PartyMemberStats temp = sortedParty[min_ind];
                sortedParty[min_ind] = sortedParty[i];
                sortedParty[i] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                sortedParty[i].RunAttack();
            }
        } else {
            partyMembers[0].RunAttack();
        }
        setTurnState(BattleState.Enemy);
    }

    private void EnemyTurn()
    {
        if (enemies.Length > 1) {
             EnemyStats[] sortedEnemies = enemies;
            int n = sortedEnemies.Length;
            for (int i = 0; i<n; i++)
            {
                int min_ind = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (sortedEnemies[j].speed < sortedEnemies[i].speed)
                    {
                        min_ind = j;
                    }
                }
                EnemyStats temp = sortedEnemies[min_ind];
                sortedEnemies[min_ind] = sortedEnemies[i];
                sortedEnemies[i] = temp;
            }
            for (int i = 0; i < n; i++)
            {
                sortedEnemies[i].RunAttack();
            }
        } else {
            enemies[0].RunAttack();
        }
        setTurnState(BattleState.Player);
    }

}
