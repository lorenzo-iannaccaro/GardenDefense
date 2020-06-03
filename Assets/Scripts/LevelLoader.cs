using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float splashDuration = 3f;
    int currentSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(LoadStartScene());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(splashDuration);
        SceneManager.LoadScene("StartScene");
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadLoseScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LoadWinScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
