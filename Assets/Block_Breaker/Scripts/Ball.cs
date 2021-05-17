using UnityEngine;

namespace BlockBreaker
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private Paddle paddle;
        [SerializeField] private float leftForce = 2f;
        [SerializeField] private float rightForce = 15f;

        private Vector2 ballToPaddleVector;
        private bool isStarted = false;

        // Start is called before the first frame update
        void Start()
        {
            ballToPaddleVector = transform.position - paddle.transform.position;
            ResetBall();
        }

        // Update is called once per frame
        void Update()
        {
            if (!isStarted)
            {
                MoveBallWithPaddle();
            }

            if (Input.GetMouseButtonDown(0))
            {
                isStarted = true;
                StartGame();
            }
        }

        private void MoveBallWithPaddle()
        {
            Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
            transform.position = paddlePos + ballToPaddleVector;
        }

        private void StartGame()
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(leftForce, rightForce);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            SoundManager.Instance.PlayBounceSound();
        }

        public void ResetBall()
        {
            isStarted = false;
        }
    }
}