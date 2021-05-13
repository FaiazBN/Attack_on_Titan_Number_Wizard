using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ConversationPart : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStoryState();


    }

    
    void Update()
    {
        ManangeStates();

    }
    private void ManangeStates()
    {
        var nextStates = state.GetNextState();

        for (int i = 0; i < nextStates.Length; i++) {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                state = nextStates[0];
            }
        }
        
        textComponent.text = state.GetStoryState();
    }
}
