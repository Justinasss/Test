using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour
{
    public Text countdownText; // Reference to the UI Text for countdown on the Canvas
    public AudioSource gameOverSound; // Reference to the AudioSource that will play the game-over sound

    private bool gameOverTriggered = false; // Flag to prevent multiple triggers

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartCountdown(3));
    }
    IEnumerator StartCountdown(int startCount)
    {
        // Countdown display at the start of the game
        for (int i = startCount; i > 0; i--)
        {
            countdownText.text = i.ToString(); // Update the countdown text on screen
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }

        // Clear countdown text when done
        countdownText.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!gameOverTriggered && other.CompareTag("Player"))
        {
            gameOverTriggered = true; // Prevent multiple triggers
            gameOverSound.Play(); // Play game over sound effect
            StartCoroutine(GameOverCountdown(3)); // Start the game-over countdown coroutine
        }
    }

    IEnumerator GameOverCountdown(int startCount)
    {
        // Countdown display for game over
        for (int i = startCount; i >= 0; i--)
        {
            countdownText.text = i.ToString(); // Update countdown on screen
            yield return new WaitForSeconds(1f); // Wait for 1 second
        }

        // Reload the scene or end the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
