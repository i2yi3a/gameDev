using UnityEditor;
using UnityEngine;

// created in VS
// uploaded into Unity
// Assets -> Create -> choose the script

    [CreateAssetMenu(menuName = "State")]
    public class State : ScriptableObject
    {
        [TextArea(14, 10)] [SerializeField] string storyText;
        // serialize State which is Array
        // this will add the field "Next" in the Unity
        // StartingState Inspector window where
        // I can define next steps
        [SerializeField] State[] nextStates;
        public string GetStateStory()
        {
            // storyText -> content defined in the Unity
            // Inspector tab

            return storyText;
        }
        
        public State[] GetNextStates()
    {
        return nextStates;
    }
    }
