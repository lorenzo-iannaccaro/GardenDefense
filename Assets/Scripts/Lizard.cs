using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    [SerializeField] float attackDamage = 50f;

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
            this.GetComponent<Attacker>().Attack(otherCollider.GetComponent<Defender>(), attackDamage);
        }
    }
}
