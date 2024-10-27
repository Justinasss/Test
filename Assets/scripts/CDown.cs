using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimpleCountdown : MonoBehaviour
{
    public Text countdownText; // Reference to the UI Text component for the countdown display

    private void Start()
    {
        // Start the countdown coroutine
        StartCoroutine(CountdownRoutine());
    }

    private IEnumerator CountdownRoutine()
    {
        // Count down from 3 to 1
        for (int countdown = 3; countdown > 0; countdown--)
        {
            // Update the UI text to show the current countdown number
            countdownText.text = countdown.ToString();

            // Wait for 1 second
            yield return new WaitForSeconds(1f);
        }

        // Clear the text after countdown is done
        countdownText.text = "";

        // Optionally, deactivate the Text object to hide it completely
        countdownText.gameObject.SetActive(false);
    }
}
