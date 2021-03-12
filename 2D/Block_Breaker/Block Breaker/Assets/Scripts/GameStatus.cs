using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameStatus : MonoBehaviour
{
    // Configuration params
    [Range(0.1f,10f)] [SerializeField] float timeSpeed = 1f;
    [SerializeField] int pointsForDestroingBlock = 1;
    [SerializeField] TextMeshProUGUI scoreText;

    // sTate variables
    [SerializeField] int currentScore = 0;

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
}
