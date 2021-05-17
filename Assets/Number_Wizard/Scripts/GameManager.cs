using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int minGuessValue;
    [SerializeField] int maxGuessValue;
    [SerializeField] TMP_Text guessText;

    int guessValue;

    private void Start()
    {
        Guessing(minGuessValue, maxGuessValue);
        UpdateValue();
    }

    private void Guessing(int min, int max) => guessValue = Random.Range(min, max + 1);

    private void UpdateValue() => guessText.text = guessValue.ToString();

    public void OnHigherBtnClick()
    {
        Guessing(guessValue, maxGuessValue);
        UpdateValue();
    }

    public void OnLowerBtnClick()
    {
        Guessing(minGuessValue, guessValue);
        UpdateValue();
    }
}
