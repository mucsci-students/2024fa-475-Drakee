using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Goal : MonoBehaviour
{
    //Variable Declarations
    public GameObject player1;
    public GameManager gameManager;

    //*********************************************************************
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("Player");
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
    }
}
