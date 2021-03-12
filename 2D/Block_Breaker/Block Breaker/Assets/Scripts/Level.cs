using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //parameters
    [SerializeField] int numberOfBlocks; // Serialize for debugging purposes
    // cached reference
    SceneLoader sceneLoader;

    private void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        // Count all blocks on the level
        // run this method in the Blocks.cs script
        numberOfBlocks++;
    }

    public void BlockDestroyed()
    {
        numberOfBlocks--;
        if (numberOfBlocks <= 0)
        {
            sceneLoader.LoadNextScene();
        }
    }


}
