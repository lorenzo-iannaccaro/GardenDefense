using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private const string PROJECTILES_PARENT_NAME = "Projectiles";

    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject gunPrefab;
    private AttackerSpawner alignedAttackerSpawner;
    private Animator animator;

    private static GameObject projectilesParent;

    // Start is called before the first frame update
    void Start()
    {
        SetAttackerSpawner();
        animator = GetComponent<Animator>();
        if (!projectilesParent)
        {
            projectilesParent = new GameObject(PROJECTILES_PARENT_NAME);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (AttackersInLine())
        {
            // do attack animation
            animator.SetBool("isAttacking", true);
        }
        else
        {
            // do idle animation
            animator.SetBool("isAttacking", false);
        }
    }

    public void Fire()
    {
        var projectileObj = Instantiate(projectilePrefab, 
                    gunPrefab.transform.position, 
                    gunPrefab.transform.rotation);

        projectileObj.transform.parent = projectilesParent.transform;
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
