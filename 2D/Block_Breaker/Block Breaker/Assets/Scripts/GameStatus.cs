using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// Singleton pattern - used here to create GameStatus/GameObject on the first level
// Second level will check if GameObject exists and will destroy its GameObject
// This way the GameScore will be preserve and will be SUM of all points get from all levels
public class GameStatus : MonoBehaviour
{
    // Configuration params
    [Range(0.1f,10f)] [SerializeField] float timeSpeed = 1f;
    [SerializeField] int pointsForDestroingBlock = 1;
    [SerializeField] TextMeshProUGUI scoreText;

    // sTate variables
    [SerializeField] int currentScore = 0;

    //Singleton Pattern
    private void Awake()
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
            DontDestroyOnLoad(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeSpeed;
    }

    public void AddPointsToScore()
    {
        //currentScore = currentScore + pointsForDestroingBlock;
        currentScore += pointsForDestroingBlock;
        scoreText.text = currentScore.ToString();
        Debug.Log(currentScore);
    }

    public void DestroyOnSceneLoad()
    {
        Destroy(gameObject);
    }
}
