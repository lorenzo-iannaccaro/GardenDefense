using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Attacker : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField][Range(0f, 5f)] float moveSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        gameObject.transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
    }
}
