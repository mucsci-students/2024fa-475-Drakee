using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    public GameObject ball;             // Reference to the ball
    public float moveSpeed = 10f;       // Speed at which the NPC moves
    public float rotationSpeed = 5f;    // Speed for rotating towards the ball
    public float kickForce = 15f;       // Force applied to the ball when "hitting" it
    public float hitDistance = 5f;     // Distance at which the NPC will try to hit the ball
    public float stopAccelerationDistance = 10f; // Distance at which the NPC will stop accelerating towards the ball and focus on rotating

    private Rigidbody npcRigidbody;

    void Start()
    {
        npcRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MoveTowardsBall();
    }

    void MoveTowardsBall()
    {
        // Calculate direction to the ball
        Vector3 directionToBall = (ball.transform.position - transform.position).normalized;
        directionToBall.y = 0; // Prevents the NPC from moving up or down

        // Rotate NPC towards the ball
        Quaternion lookRotation = Quaternion.LookRotation(directionToBall);
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        // Move forward
        npcRigidbody.AddForce(transform.forward * moveSpeed);

        // Check distance to the ball
        float distanceToBall = Vector3.Distance(transform.position, ball.transform.position);

        // If within range, apply kick force
        if (distanceToBall <= hitDistance)
        {
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            if (ballRigidbody != null)
            {
                ballRigidbody.AddForce(directionToBall * kickForce, ForceMode.Impulse);
            }
        }
        // Check to see if the npc is too far and that it is not looking at the ball within a certain range
        else if (distanceToBall >= stopAccelerationDistance && Vector3.Angle(transform.forward, directionToBall) > 30f)
        {
            // Slow down if too far from the ball
            if (npcRigidbody.velocity.normalized == transform.forward) 
            {
                npcRigidbody.velocity -= transform.forward * moveSpeed;
            }
            else
            {
                npcRigidbody.velocity = Vector3.zero;
            }
        }
    }
}
