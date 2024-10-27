using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stops : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("OnCollisionEnter2D detected with: " + collision.gameObject.name);

        
        if (collision.gameObject.CompareTag("Finish"))
        {
            
            Time.timeScale = 0f;  // Stops the game
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("OnTriggerEnter2D detected with: " + other.gameObject.name);

        
        if (other.CompareTag("Finish"))
        {
            
            Time.timeScale = 0f;  // Stops the game
        }
    }
}
