﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // 
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to Number Wizard Game");
        Debug.Log("Please Pick up a Number");
        Debug.Log("The Highest Number is " + max);
        Debug.Log("The Lowest Number is " + min);
        Debug.Log("Tell me if your number is higher or lower than " + guess + "?");
        Debug.Log("Push Up = Higher, Push Down = Lower, push Enter = Correct");
        max += 1;
        min -= 1;
    }


    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Well done.");
            StartGame();
        }
    }
    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than - " + guess + "?");
    }
}
