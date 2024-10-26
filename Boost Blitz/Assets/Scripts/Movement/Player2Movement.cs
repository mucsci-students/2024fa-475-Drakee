using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{
    public GameObject player;
    private Rigidbody playerRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            // increase the players velocity in the direction they are facing
            playerRigidbody.velocity += player.transform.forward * .25f;
            
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            // check to see if the player is moving forward
            if (playerRigidbody.velocity.normalized == player.transform.forward)
            {
                playerRigidbody.velocity -= player.transform.forward * .5f;
            }
            else 
            {
                playerRigidbody.velocity -= player.transform.forward * .25f;
            }
            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // rotate the player 15 degrees to the left
            player.transform.Rotate(0, -1, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            player.transform.Rotate(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.transform.position = new Vector3(1, 2, 32);
            player.transform.rotation = new Quaternion(0, 180, 0, 0);
            playerRigidbody.velocity = new Vector3(0, 0, 0);
        }
    }
}
