using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalCollisions : MonoBehaviour
{
    //Variable Declarations
    public GameObject player1;
    public GameObject player2;
    //public GameObject ball;   attach script to ball object.
    public GameManager gameManager;

    //*********************************************************************
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Call updatePlayerScore
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GoalPlayer1"))
        {
            gameManager.updatePlayerScore(player1);
        }
        if (collision.gameObject.CompareTag("GoalPlayer2"))
        {
            gameManager.updatePlayerScore(player2);
        }
    }
}
