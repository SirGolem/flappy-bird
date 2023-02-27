using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public string menuScene;
    public string gameScene;

    public void LoadMenu()
    {
        LoadScene(menuScene);
    }

    public void LoadGame()
    {
        LoadScene(gameScene);
    }

    private void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
}
