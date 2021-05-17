using UnityEngine;

namespace BlockBreaker
{
    public class Block : MonoBehaviour
    {
        [SerializeField] private int blockScore = 100;

        private void Start()
        {
            GameManager.Instance.remainingBlocks++;
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SoundManager.Instance.PlayBreakSound();

            GameManager.Instance.Score += Random.Range(blockScore - 10, blockScore);

            GameManager.Instance.Subtract1Block();

            Destroy(gameObject);
        }
    }
}