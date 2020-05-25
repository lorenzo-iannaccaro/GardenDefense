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

    private IEnumerator LoadStartScene()
    {
        yield return new WaitForSeconds(splashDuration);
        SceneManager.LoadScene("StartScene");
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
