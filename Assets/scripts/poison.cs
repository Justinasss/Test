using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionStop : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D detected with: " + collision.gameObject.name);

        // Check if the collided object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision with Player detected! Stopping the game.");
            Time.timeScale = 0f;  // Stops the game
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D detected with: " + other.gameObject.name);

        // Check if the collided object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger with Player detected! Stopping the game.");
            Time.timeScale = 0f;  // Stops the game
        }
    }
}
