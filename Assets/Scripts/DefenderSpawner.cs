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
        SpawnDefender(GetPositionClicked());
    }

    private void SpawnDefender(Vector2 coordinates)
    {
        var defenderObj = Instantiate(defenderPrefab, coordinates, transform.rotation);
    }

    private Vector2 GetPositionClicked()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return worldPosition;
    }
}
