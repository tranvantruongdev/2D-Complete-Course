using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlockBreaker
{
    public class ScreenLoader : MonoBehaviour
    {
        public void PlayAgain()
        {
            SceneManager.LoadScene(GameManager.Instance.CurrentLevel);
        }

        public void Quit()
        {
            Application.Quit();
        }

        public void MainMenu()
        {
            GameManager.Instance.MainMenu();
        }

        private void Start()
        {
            GameManager.Instance.CreateBlocks();

            GameManager.Instance.Ball = FindObjectOfType<Ball>();
        }
    }
}