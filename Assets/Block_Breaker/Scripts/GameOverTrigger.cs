using UnityEngine;

namespace BlockBreaker
{
    public class GameOverTrigger : MonoBehaviour
    {
        GameManager GameManager;

        // Start is called before the first frame update
        void Start() => GameManager = FindObjectOfType<GameManager>();

        private void OnTriggerEnter2D(Collider2D collision) => GameManager.GameOver();
    }
}
