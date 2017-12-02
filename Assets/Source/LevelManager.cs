using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadLevel(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
