using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    float defaultVolume = 0.75f;

    // Start is called before the first frame update
    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetGameVolume();
    }

    // Update is called once per frame
    void Update()
    {
        MusicPlayer musicPlayer = FindObjectOfType<MusicPlayer>();
        if (!musicPlayer) return;
        musicPlayer.SetVolume(volumeSlider.value);
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetGameVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenuScene();
    }

    public void SetDefaultValues()
    {
        volumeSlider.value = defaultVolume;
    }
}
