using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startState;

    State State;

    // Start is called before the first frame update
    void Start()
    {
        State = startState;
        textComponent.text = State.StoryText;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            State = State.NextState[0];
            ChangeDisplay();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            State = State.NextState[1];
            ChangeDisplay();
        }
    }

    private void ChangeDisplay()
    {
        textComponent.text = State.StoryText;
    }
}
