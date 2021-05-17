using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] State[] nextState;

    public string StoryText { get => storyText; set => storyText = value; }
    public State[] NextState { get => nextState; set => nextState = value; }
}
