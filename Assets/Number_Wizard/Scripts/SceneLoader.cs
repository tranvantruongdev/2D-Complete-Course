using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        var currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(++currentIndex);
    }

    public void LoadStartScene() => SceneManager.LoadScene(0);

    public void QuitGame() => Application.Quit();

}
