using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] float baseLives = 5;
    float lives;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetGameDifficulty() * 2;
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public float GetLives()
    {
        return this.lives;
    }

    public void DecreaseLives()
    {
        if (lives <= 0) return;
        lives--;
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
