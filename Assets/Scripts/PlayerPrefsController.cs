using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsController : MonoBehaviour
{
    private const string GAME_VOLUME = "game volume";
    private const string GAME_DIFFICULTY = "game difficulty";

    private const float MIN_VOLUME = 0f;
    private const float MAX_VOLUME = 1f;

    private const float MIN_DIFFICULTY = 0f;
    private const float MAX_DIFFICULTY = 2f;

    public static float GetGameVolume()
    {
        return PlayerPrefs.GetFloat(GAME_VOLUME);
    }

    public static float GetGameDifficulty()
    {
        return PlayerPrefs.GetFloat(GAME_DIFFICULTY);
    }

    public static void SetGameVolume(float volume)
    {
        if(volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            PlayerPrefs.SetFloat(GAME_VOLUME, volume);
        }
    }

    public static void SetGameDifficulty(float difficulty)
    {
        if(difficulty >= MIN_DIFFICULTY && difficulty <= MAX_DIFFICULTY)
        {
            PlayerPrefs.SetFloat(GAME_DIFFICULTY, difficulty);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
