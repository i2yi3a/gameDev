using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Serialize field are available from Unity GUI and value can be changed
    // from the Unity
    [SerializeField] int min;
    [SerializeField] int max;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
     
    // Start is called before the first frame update
    void Start()
    {       
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // 
    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        // refering to the text method of TextMeshProUGUI
        // and adding guess value as a String into the Guess field in Unity
        guessText.text = guess.ToString();
    }

    public void onPressHigher()
    {
        if (min < max){
            min = guess + 1;
        }
        NextGuess();
    }

    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();
    }


}
