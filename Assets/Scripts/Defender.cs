using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] int moneyCost = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney(int amount)
    {
        var moneyDisplay = FindObjectOfType<MoneyDisplay>();
        moneyDisplay.AddMoney(amount);
    }

    public int GetMoneyCost()
    {
        return moneyCost;
    }
}
