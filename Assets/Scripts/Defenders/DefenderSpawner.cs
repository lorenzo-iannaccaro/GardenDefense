using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defenderPrefab;

    public void SetSelectedDefender(Defender selectedDefender)
    {
        defenderPrefab = selectedDefender;
    }

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
        Vector2 worldPosition = GetPositionFromClickedPoint();
        Vector2 roundedPosition = GetGridPosition(worldPosition);
        SpawnIfAffordable(roundedPosition);

    }

    private void SpawnIfAffordable(Vector2 roundedPosition)
    {
        if (defenderPrefab.GetMoneyCost() <= FindObjectOfType<MoneyDisplay>().GetActualMoney())
        {
            SpawnDefender(roundedPosition);
            FindObjectOfType<MoneyDisplay>().SpendMoney(defenderPrefab.GetMoneyCost());
        }
    }

    private void SpawnDefender(Vector2 coordinates)
    {
        Defender defenderObj = Instantiate(defenderPrefab, coordinates, transform.rotation);
        defenderObj.transform.parent = this.transform;
    }

    private Vector2 GetGridPosition(Vector2 worldPos)
    {
        int gridX = Mathf.RoundToInt(worldPos.x);
        int gridY = Mathf.RoundToInt(worldPos.y);
        return new Vector2(gridX, gridY);
    }

    private Vector2 GetPositionFromClickedPoint()
    {
        Vector2 clickPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(clickPosition);
        return worldPosition;
    }
}
