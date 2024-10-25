using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Tags:
    /*
     * Player  = Human Player 1
     * Player2 = Human Player 2 |OR| AI Player
     * 
     * GoalPlayer1 = Human Player 1's Goal
     * GoalPlayer2 = Human Player 2's Goal |OR| AI's Goal
     */


    //Variable Declarations
    public GameObject player1;
    public GameObject player2;
    public GameObject ball;

    private int player1Score = 0;
    private int player2Score = 0;
    private int pauseKeyCount = 0;

    private bool isGamePaused;

//*********************************************************************
    // Start is called before the first frame update
    void Start()
    {
      player1 = GameObject.FindGameObjectWithTag("Player");
      ball = GameObject.FindGameObjectWithTag("Ball");
    }

    // Update is called once per frame
    void Update()
    {
        //Manage game pausing.
        isGamePaused = Input.GetKeyDown(KeyCode.P);
        OnApplicationPause(isGamePaused);

        //Is the game over?
        if ((player1Score == 5) || (player2Score == 5))
        {
            endOfGame();
        }
    }

    //OnCollisionEnter method will be done in a seperate script, since we are working with two players that need to be handled different.
        //i could do it in the "PlayerMovement" script, but this may cause problems when implementing AI.

    //Call this method in the new script.
    public void updatePlayerScore (GameObject whichPlayer) 
    {
        if (whichPlayer.CompareTag("Player"))
        {
            player1Score++;
            Debug.Log("Player 1 Score is " + player1Score);
        }
        if (whichPlayer.CompareTag("Player2"))
        {
            player2Score++;
            Debug.Log("Player 2 Score is " + player2Score);
        }
    }

    private void OnApplicationPause(bool pause)
    {
        if (pause == true)
        {
            pauseKeyCount++;
        }
        //Pauses the game.
        if (pauseKeyCount == 1)
        {
            //Debug.Log("Game Paused");
            Time.timeScale = 0f;
            player1.SetActive(false);
            //player2.SetActive(false);
        }
        //Unpauses the game.
        if (pauseKeyCount == 2)
        {
            Time.timeScale = 1f;
            player1.SetActive(true);
            //player2.SetActive(true);
            pause = false;
            pauseKeyCount = 0;
        }
    }

    //Should be called when score = 5
    void endOfGame()
    {
        Time.timeScale = 0f;
        player1.SetActive(false);
        //player2.SetActive(false);

        //Debug.Log("The game has ended.");
    }
}
