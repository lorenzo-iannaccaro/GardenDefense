using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Attacker : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField][Range(0f, 5f)] float currentSpeed = 0f;
    Defender currentTarget;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (!currentTarget)
        {
            this.GetComponent<Animator>().SetBool("isAttacking", false);
        }
    }

    private void Move()
    {
        gameObject.transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }

    public void SetCurrentSpeed(float speedToSet)
    {
        currentSpeed = speedToSet;
    }

    public void Attack(Defender target)
    {
        currentTarget = target;
        if (!currentTarget) return;
        this.GetComponent<Animator>().SetBool("isAttacking", true);
    }

    public void DoAttack(float damage)
    {
        if (!currentTarget) return;
        currentTarget.GetComponent<Health>().DealDamage(damage);
    }

}
