using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    int attackersNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<GameTimer>().IsTimeUp())
        {
            StopAttackerSpawners();
            if(attackersNumber == 0)
            {
                Debug.Log("level win");
                FindObjectOfType<LevelLoader>().LoadWinScene();
            }
        }
    }

    private void StopAttackerSpawners()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner spawner in attackerSpawners)
        {
            if (spawner.IsSpawning())
            {
                spawner.StopSpawning();
            }
        }
    }

    public void AttackerSpawned()
    {
        attackersNumber++;
    }

    public void AttackerDestroyed()
    {
        attackersNumber--;
    }
}
