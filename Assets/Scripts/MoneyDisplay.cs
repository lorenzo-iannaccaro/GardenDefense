using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyDisplay : MonoBehaviour
{
    [SerializeField] int money = 100;
    Text moneyText;

    // Start is called before the first frame update
    void Start()
    {
        moneyText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateDisplay()
    {
        moneyText.text = money.ToString();
    }

    public void AddMoney(int moneyToAdd)
    {
        money += moneyToAdd;
        UpdateDisplay();
    }

    public void SpendMoney(int moneySpent)
    {
        if(money >= 0)
        {
            money -= moneySpent;
            if(money < 0)
            {
                money = 0;
            }
            UpdateDisplay();
        }
    }

    public int GetActualMoney()
    {
        return money;
    }
}
