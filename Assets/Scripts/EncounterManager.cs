using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EncounterManager : MonoBehaviour
{
    public List<EnemyStats> PossibleEncounters;

    public int max, threshold;

    public void GenerateEncounter()
    {
        int encounter = Random.Range(0, max);

        if (encounter > threshold) {
            int encounterEnemy = Random.Range(0, PossibleEncounters.Count);
            Debug.Log(encounterEnemy);
            BattleData.enemy1 = PossibleEncounters[encounterEnemy];
            encounterEnemy = Random.Range(-1, PossibleEncounters.Count);
            Debug.Log(encounterEnemy);
            if (encounterEnemy != -1) 
            {
                BattleData.enemy2 = PossibleEncounters[encounterEnemy];
                encounterEnemy = Random.Range(-1, PossibleEncounters.Count);
                Debug.Log(encounterEnemy);
                if (encounterEnemy != -1) 
                {
                    BattleData.enemy3 = PossibleEncounters[encounterEnemy];
                    encounterEnemy = Random.Range(-1, PossibleEncounters.Count);
                    Debug.Log(encounterEnemy);
                    if (encounterEnemy != -1) 
                    {
                        BattleData.enemy4 = PossibleEncounters[encounterEnemy];
                    }
                }
            }
            LoadingData.setSceneToLoad(3);
            SceneManager.LoadScene(1);
            
        }
    }
}
