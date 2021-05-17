using UnityEngine;
using UnityEngine.SceneManagement;

namespace BlockBreaker
{
    public class Paddle : MonoBehaviour
    {
        private const float screenWidthUnits = 22f;

        [SerializeField] private float minX = -1f;
        [SerializeField] private float maxX = 21f;

        // Update is called once per frame
        void Update()
        {
            float paddlePosX = Input.mousePosition.x / Screen.width * screenWidthUnits;
            float limitX = Mathf.Clamp(paddlePosX, minX, maxX);
            transform.position = new Vector2(limitX, transform.position.y);
        }
    }
}