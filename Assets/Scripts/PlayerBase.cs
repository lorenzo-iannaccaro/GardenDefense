using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
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
        PlayerHealthDisplay playerLivesObj = FindObjectOfType<PlayerHealthDisplay>();
        playerLivesObj.DecreaseLives();
        Destroy(otherCollider.gameObject);
    }
}
