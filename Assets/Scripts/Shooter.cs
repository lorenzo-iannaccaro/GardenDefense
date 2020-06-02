using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject gunPrefab;
    private AttackerSpawner alignedAttackerSpawner;

    // Start is called before the first frame update
    void Start()
    {
        SetAttackerSpawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (AttackersInLine())
        {
            // do attack animation
        }
        else
        {
            // do idle animation
        }
    }

    public void Fire()
    {
        Instantiate(projectilePrefab, 
                    gunPrefab.transform.position, 
                    gunPrefab.transform.rotation);
    }

    private void SetAttackerSpawner()
    {
        AttackerSpawner[] attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach(AttackerSpawner attackerSpawner in attackerSpawners)
        {
            bool isAligned = Mathf.Abs(this.transform.position.y - attackerSpawner.transform.position.y) <= Mathf.Epsilon;
            if (isAligned)
            {
                alignedAttackerSpawner = attackerSpawner;
            }
        }
    }

    private bool AttackersInLine()
    {
        if(alignedAttackerSpawner.transform.childCount > 0)
        {
            return true;
        }
        return false;
    }
}
