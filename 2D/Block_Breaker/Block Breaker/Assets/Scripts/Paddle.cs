using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float leftBoarder = 1f;
    [SerializeField] float rightBoarder = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 16 <- the number of the unity units is on the screen from left to right
        float mouseCurrentPositionX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        
        // New vector (position) in which Paddle will be placed
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y);
        paddlePosition.x = Mathf.Clamp(mouseCurrentPositionX, leftBoarder, rightBoarder);


        // in the Unity Paddle has a Transform component (right panel)
        // so below we are referring to the Position X, Y and giving
        // the values from above 
        transform.position = paddlePosition;
    }
}
