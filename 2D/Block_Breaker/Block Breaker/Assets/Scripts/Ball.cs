using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // config parameters connecting Ball <-> Paddle
    [SerializeField] Paddle paddle1;
    [SerializeField] Vector2 firstPushVector;
    [SerializeField] AudioClip[] ballSounds;

    //State - distance between the Paddle and the Ball
    Vector2 paddleToBallVector;
    bool hasStarted = false;

    //Cached component references
    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        // set the Vector which will calculate the [X,Y]
        // difference between center of Paddle and Ball
        paddleToBallVector = transform.position - paddle1.transform.position;
        // this will be needed to store Audio from Block object
        // when this object will be destroyed
        // but we want to play whole sound
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // If user didn't click on the mouse button the ball is stick to paddle
        // after hasStarted update in the LaunchOnMouseClick method
        // it will be bouncing and there is no need to use below 2 method
        if (!hasStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void LockBallToPaddle()
    {
        //check the paddle position
        Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);

        // set the Ball position basic on the Paddle position
        // and add vector to place Ball above the Paddle
        transform.position = paddlePosition + paddleToBallVector;
    }

    private void LaunchOnMouseClick()
    {   
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = firstPushVector;
            hasStarted = true;
        }
           
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // start sound only when game started not before
        if (hasStarted)
        {
            // to play one Single audio use below
            //GetComponent<AudioSource>().Play();

            //to use array of sounds use below
            //first define array of sounds and randomly choose the sound to play
            //random - Random.Range <- mean select random from some range
            //(0,ballSounds.Lengths) <- mean take clip number from 0 to all number of added clips i.e. number of clips = 9
            // so the range will be from 0 - 9
            AudioClip clip = ballSounds[UnityEngine.Random.Range(0,ballSounds.Length)];
            myAudioSource.PlayOneShot(clip) ;
        }
        
    }
}
