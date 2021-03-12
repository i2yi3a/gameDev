using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;

    // cached reference part 1 - 
    // used to avoid calls in Update method
    // the caching will be during Start method and update later
    // it is less expensive than placing whole GetComponent in Update 
    Level level;
    GameStatus gameStatus;

    private void Start()
    {
        // caching references part 2 -
        // way of caching referance during Start method
        level = FindObjectOfType<Level>();
        gameStatus = FindObjectOfType<GameStatus>();
        // counting all blocks on the start of the game
        level.CountBlocks();
    }

    // Destroy block
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBlock();
    }

    private void DestroyBlock()
    {
        // check if sound clip file has been added to the component (block in this case)
        // without this check if ball destroy block without clip
        // game will break because will want to play non-existing clip
        if (breakSound)
        {
            AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
        }
        // Destroy - method in Unity to destroy object
        // gameObject - describe game object where this scipt is placed (in this case Block element in Unity)
        gameStatus.AddPointsToScore();
        Destroy(gameObject);
        level.BlockDestroyed();
        Debug.Log(gameObject.name);
    }
}
