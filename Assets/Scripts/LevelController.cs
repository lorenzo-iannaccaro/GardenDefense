using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] GameObject winCanvas;
    [SerializeField] GameObject loseCanvas;
    [SerializeField] float winPauseTime = 3f;
    [SerializeField] float losePauseTime = 3f;
    int attackersNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        winCanvas.SetActive(false);
        loseCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<PlayerHealthDisplay>().GetLives() <= 0)
        {
            StartCoroutine(ProcessLose());
            return;
        }
        if (FindObjectOfType<GameTimer>().IsTimeUp())
        {
            StopAttackerSpawners();
            if(attackersNumber == 0)
            {
                Debug.Log("level win");
                StartCoroutine(ProcessWin());
            }
        }
    }

    IEnumerator ProcessWin()
    {
        winCanvas.SetActive(true);
        yield return new WaitForSeconds(winPauseTime);
        FindObjectOfType<LevelLoader>().LoadWinScene();
    }

    IEnumerator ProcessLose()
    {
        loseCanvas.SetActive(true);
        yield return new WaitForSeconds(losePauseTime);
        FindObjectOfType<LevelLoader>().LoadLoseScene();
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
