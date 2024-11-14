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
    public GameObject controlsDisplay;

    public Camera delayCamera;

    private Button quitBtn;
    private Button menuBtn;

    public ScenesManager scenesManager;

    private int player1Score = 0;
    private int player2Score = 0;
    private int pauseKeyCount = 0;
    private int startDelay = 0;
    private int goalInt = 0;

    private bool isGamePaused = false;
    private bool hasScored = false;
    private bool isInitialDelay = false;
    private bool hasPassedControlScreen = false;
    private bool isGoalShown = false;

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
        controlsScreen();
        deactivate();
        Debug.Log("Start has been called.");
    }

    void Update()
    {
        //Manage game pausing. (doesnt work properly in fixedupdate for some reason)
        isGamePaused = Input.GetKeyDown(KeyCode.P);
        OnApplicationPause(isGamePaused);

        //Manage the start control screen. Uses seperate booleans so that the start delay and pausing work properly.
        bool commaInput = Input.GetKeyDown(KeyCode.Comma);
        if (commaInput == true)
        {
            hasPassedControlScreen = true;
            isInitialDelay = true;
        }
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
            controlsDisplay.SetActive(false);
            Text delayText = delayDisplay.GetComponent<Text>();
            deactivate();

            //show that a goal has been scored.
            //************************************************************************

            if (isGoalShown == true)
            {
                delayText.text = "GOAL";
                goalInt++;
                //startDelay = 0;
            }
            //GOAL text is shown for a few seconds before the start delay countdown (granted a player has scored).
            if (goalInt >= 250)
            {
                isGoalShown = false;
                //goalInt = 0;
            }

            //*****************************************************************************

            //if the goal text is being shown, the start delay cannot happen.
            if ((hasScored == true) && (isInitialDelay == false) && (goalInt < 250))
            {
                isGoalShown = true;
            }
            //manage the start delay.
            else
            {
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
                    goalInt = 0;
                    isInitialDelay = false;
                    activate();
                    Debug.Log("Start");
                    //delayText.text = "Start";
                    //init btns
                    if (quitBtn == null)
                    {
                        quitBtn = delayDisplay.transform.Find("quitBtn").GetComponent<Button>();
                        quitBtn.onClick.AddListener(OnQuitButtonClicked);
    
                        
                    }
                    if (menuBtn == null)
                    {
                        menuBtn = delayDisplay.transform.Find("menuBtn").GetComponent<Button>();
                        menuBtn.onClick.AddListener(OnMenuButtonClicked);                        
                    }
                    delayText.text = "Paused";
                    Debug.Log("Start Delay Complete.");
                }
            }

        }
    }

    //OnCollisionEnter method will be done in a seperate script, since we are working with two players that need to be handled different.
    //Also, the players do not have the GameManager attached to them.
    //Call this method in the new script [GoalCollisions].
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

    void showPlayerScore()
    {
        Text scoreText = scoreDisplay.GetComponent<Text>();
        scoreText.text = (player1Score.ToString() + " || " + player2Score.ToString());
    }

    void controlsScreen()
    {
        Text controlsText = controlsDisplay.GetComponent<Text>();

        //should be different dependent on game mode. use to display different control screens.
        string currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;

        //the strings are formatted this way because of how text prints on screen. it is not a good 1:1 translation.
        if (currentScene.Equals("Multiplayer"))
        {
            string[] controls = new string[7];
            controls[0] = "     Player 1 (Top Screen)                             Player 2 (Bottom Screen)" + "\n" + "     -----------------------------                             ---------------------------------" + "\n";
            controls[1] = "  Movement:   WASD Keys                                     Arrow Keys" + "\n";
            controls[2] = "  Boost:           V         Key                                      J         Key " + "\n";
            controls[3] = "  Camera:       C         Key                                      K         Key " + "\n";
            controls[4] = "\n" + "                           Press the [N] Key to Skip the Current Music Track.";
            controls[5] = "\n" + "                           Press the [P] Key to Pause (in-game).";
            controls[6] = "\n" + "\n" + "                           Press the [Comma] Key to Continue.";

            controlsText.text = controls[0] + controls[1] + controls[2] + controls[3] + controls[4] + controls[5] + controls[6];
        }
        else if (currentScene.Equals("SinglePlayer"))
        {
            string[] controls = new string[7];
            controls[0] = "     SinglePlayer Controls" + "\n" + "     -----------------------------" + "\n";
            controls[1] = "     Movement:  WASD Keys" + "\n";
            controls[2] = "   Boost:          V         Key" + "\n";
            controls[3] = "   Camera:       C         Key" + "\n";
            controls[4] = "\n" + "                        Press the [N] Key to Skip the Current Music Track.";
            controls[5] = "\n" + "    Press the [P] Key to Pause (in-game).";
            controls[6] = "\n" + "\n" + "   Press the [Comma] Key to Continue.";

            controlsText.text = controls[0] + controls[1] + controls[2] + controls[3] + controls[4] + controls[5] + controls[6];
        }
    }
    private void OnApplicationPause(bool pause)
    {
        if ((pause == true) && (hasPassedControlScreen == true))
        {
            pauseKeyCount++;
        }
        //Pauses the game.
        if (pauseKeyCount == 1)
        {
            //Debug.Log("Game Paused");
            quitBtn.gameObject.SetActive(true);
            menuBtn.gameObject.SetActive(true);
            deactivate();
        }
        //Unpauses the game.
        if (pauseKeyCount == 2)
        {
            activate();
            quitBtn.gameObject.SetActive(false);
            menuBtn.gameObject.SetActive(false);
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
        Debug.Log("The game has ended.");
        hasScored = false;
        deactivate();

        //Use delayText since that camera is being used. save variables/memory.
        Text delayText = delayDisplay.GetComponent<Text>();
        string[] endOfGameText = new string[5];

        //show who won the game.
        if (player1Score == 5)
        {
            endOfGameText[0] = "Player 1 Wins!" + "\n" + "Better luck next time, Player 2 !";
        }
        else if (player2Score == 5)
        {
            endOfGameText[0] = "Player 2 Wins!" + "\n" + "Better luck next time, Player 1 !";
        }

        delayText.text = endOfGameText[0];

        Invoke("OnMenuButtonClicked",5f);
        //give the player the option to either replay, choose a new game mode, or quit.
        //each option could have its own method that is called here dependent on what you choose.
    }

    //Getters:
    //**************************************************************************************************

    public bool getHasScored()
    {
        return hasScored;
    }

    public bool getIsGamePaused()
    {
        return isGamePaused;
    }

    //called by listeners
    //**************************************************************************************************
    void OnQuitButtonClicked()
    {
        quitBtn.gameObject.SetActive(false);
        menuBtn.gameObject.SetActive(false);
        Debug.Log("Quit button clicked!");
        Application.Quit();
    }

    void OnMenuButtonClicked()
    {
        deactivate();
        Debug.Log("Menu button clicked!");
        //ScenesManager.Instance.LoadMainMenu();
        scenesManager.LoadMainMenu();
    }
}
