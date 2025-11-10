using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string MainGameScene;

    public void PlayGame()
    {
        SceneManager.LoadScene(MainGameScene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
