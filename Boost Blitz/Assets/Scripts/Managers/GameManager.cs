using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject delayDisplay;
    public GameObject scoreDisplay;
    //public TextMeshProUGUI scoreText;
    //public Text scoreText = scoreDisplay.transform.GetChild(0);
    //public Text scoreText;

    public Camera delayCamera;

    private int player1Score = 0;
    private int player2Score = 0;
    private int pauseKeyCount = 0;
    private int startDelay = 0;

    private bool isGamePaused;
    private bool hasScored = false;
    private bool isInitialDelay = true;

    private Vector3 ogBallPosition;
    private Vector3 ogPlayer1Position;
    private Vector3 ogPlayer2Position;

//*********************************************************************
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        ball = GameObject.FindGameObjectWithTag("Ball");
        ogBallPosition = ball.transform.position;
        ogPlayer1Position = player1.transform.position;
        ogPlayer2Position = player2.transform.position;
        showPlayerScore();
        Debug.Log("Start has been called.");
    }

    void Update()
    {
        //Manage game pausing. (doesnt work properly in fixedupdate for some reason)
        isGamePaused = Input.GetKeyDown(KeyCode.P);
        OnApplicationPause(isGamePaused);
    }

    //Dependent on every FIXED Frame [Not Dependent on Hardware Performance like Update is]
    void FixedUpdate()
    {
        //Is the game over?
        if ((player1Score == 5) || (player2Score == 5))
        {
            endOfGame();
        }

        //Trigger the start delay if a player has scored. (triggered by updatePlayerScore)
        if ((hasScored == true) || (isInitialDelay == true))
        {
            Text delayText = delayDisplay.GetComponent<Text>();

            deactivate();
            //incrementing 50 per second
            startDelay++;

            if (startDelay == 1)
            {
                Debug.Log("3");
                delayText.text = "3";
            }

            if (startDelay == (50))
            {
                Debug.Log("2");
                delayText.text = "2";
            }
            if (startDelay == (100))
            {
                Debug.Log("1");
                delayText.text = "1";
            }
            //start delay is complete.
            if (startDelay == 150)
            {
                hasScored = false;
                startDelay = 0;
                isInitialDelay = false;
                activate();
                Debug.Log("Start");
                //delayText.text = "Start";
                delayText.text = "Paused";
                Debug.Log("Start Delay Complete.");
            }
        }
    }

    //OnCollisionEnter method will be done in a seperate script, since we are working with two players that need to be handled different.
    //Also, the players do not have the GameManager attached to them.
    //Call this method in the new script.
    public void updatePlayerScore (GameObject whichPlayer) 
    {
        if (whichPlayer.CompareTag("Player"))
        {
            player1Score++;
            Debug.Log("Player 1 Score is " + player1Score);
            resetPositions();
            hasScored = true;
        }
        if (whichPlayer.CompareTag("Player2"))
        {
            player2Score++;
            Debug.Log("Player 2 Score is " + player2Score);
            resetPositions();
            hasScored = true;
        }
    }

    public void showPlayerScore()
    {
        Text scoreText = scoreDisplay.GetComponent<Text>();
        scoreText.text = (player1Score.ToString() + " || " + player2Score.ToString());
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
            deactivate();
        }
        //Unpauses the game.
        if (pauseKeyCount == 2)
        {
            activate();
            pause = false;
            pauseKeyCount = 0;
        }
    }

    //activates player control and time.
    void activate()
    {
        //Time.timeScale = 1f;
        player1.SetActive(true);
        player2.SetActive(true);
        ball.SetActive(true);

        delayCamera.enabled = false;
        delayDisplay.SetActive(false);
        showPlayerScore();
    }

    //opposite of activate
    void deactivate()
    {
        //Time.timeScale = 0f;
        player1.SetActive(false);
        player2.SetActive(false);
        ball.SetActive(false);

        delayCamera.enabled = true;
        delayDisplay.SetActive(true);
    }

    //reset ball and player positions as well as their rotations & velocities.
    void resetPositions()
    {
        ball.transform.position = ogBallPosition;
        ball.transform.rotation = Quaternion.identity;
        ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        player1.transform.position = ogPlayer1Position;
        player1.transform.rotation = Quaternion.identity;
        player1.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);

        player2.transform.position = ogPlayer2Position;
        player2.transform.rotation = new Quaternion(0, 180, 0, 0);
        player2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
    }

    //Should be called when score = 5
    void endOfGame()
    {
        deactivate();

        //Debug.Log("The game has ended.");
        //trigger other fun stuff that should happen.
            //maybe show who won the game, and then give you the option to either replay, choose a new game mode, or quit.
            //each option could have its own method that is called here dependent on what you choose.
    }
}
