using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthDisplay : MonoBehaviour
{
    [SerializeField] int lives = 5;
    Text livesText;

    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }

    public void DecreaseLives()
    {
        if (lives <= 0) return;
        lives--;
        UpdateDisplay();
        if(lives <= 0)
        {
            // load start menu scene
            FindObjectOfType<LevelLoader>().LoadLoseScene();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
