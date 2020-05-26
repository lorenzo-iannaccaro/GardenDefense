using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defenderPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Mouse downclick on area");
        SpawnDefender();
    }

    private void SpawnDefender()
    {
        var defenderObj = Instantiate(defenderPrefab, transform.position, transform.rotation);
    }
}
