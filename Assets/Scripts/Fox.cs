using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.GetComponent<Defender>())
        {
            if (otherCollider.GetComponent<Gravestone>())
            {
                this.GetComponent<Animator>().SetTrigger("jump");
            }
            else
            {
                this.GetComponent<Attacker>().Attack(otherCollider.GetComponent<Defender>());
            }
            
        }
    }

}
