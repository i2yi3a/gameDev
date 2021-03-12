using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    // serializeField mean that we can change it in the Unity Game project
    // new field appear in the "Game" element Inspector tab on the right
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    void Start()
    {
        state = startingState;
        // get the text from StartingState (scriptable object)
        textComponent.text = state.GetStateStory();
    }

    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        // store the next states of the story
        var nextStates = state.GetNextStates();

        // check how many States are on the Step
        // In the For loop check if user click the State counting from 0
        // If user click something > lenght it won't access IF loop
        for (var i=0;i<nextStates.Length;i++) {
            if (Input.GetKeyDown(KeyCode.Alpha1+i))
            {
                // nextStates[0] mean that we are using Element0
                // from the list from Unity
                state = nextStates[i];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
