using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlockBreaker
{
    public partial class GameManager : Singleton<GameManager>
    {
        internal int remainingBlocks = 0;

        private int currentLevel = 0;
        private GameObject currentBlocks;
        internal Ball Ball;

        [SerializeField]
        private GameObject[] levels;
        [SerializeField]
        private int score = 0;

        internal int CurrentLevel { get => currentLevel; set => currentLevel = value; }
        public int Score { get => score; set => score = value; }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                Subtract1Block();
            }
            if (Input.GetKeyDown(KeyCode.N))
            {
                NextLevel();
            }
        }

        public void Subtract1Block()
        {
            remainingBlocks -= 1;

            if (remainingBlocks <= 0)
            {
                NextLevel();
            }
        }

        public void StartGame()
        {
            SceneManager.LoadScene((int)GameStage.MAINGAME);

            SetCurrentLevelIndex(0);
        }

        internal void CreateBlocks()
        {
            currentBlocks = Instantiate(levels[CurrentLevel], levels[CurrentLevel].transform.position, Quaternion.identity);
        }

        private void SetCurrentLevelIndex(int index)
        {
            CurrentLevel = index;
        }

        public void MainMenu() => SceneManager.LoadScene((int)GameStage.START);

        public void GameOver() => SceneManager.LoadScene((int)GameStage.GAMEOVER);

        public void NextLevel()
        {
            Destroy(currentBlocks);

            Ball.ResetBall();

            SetCurrentLevelIndex(CurrentLevel + 1);

            CreateBlocks();
        }

        public void QuitGame() => Application.Quit();
    }
}