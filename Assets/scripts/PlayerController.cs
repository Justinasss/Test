using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public int score = 0; 
    public TMP_Text scoreText;

    
    void Start()
    {
        UpdateScoreText();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Candy")) 
        {
            
            score += 10;
            UpdateScoreText();

            
            Destroy(other.gameObject);
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = score.ToString("D4"); 
        }
    }
    void OnTriggerEnter(Collider2D other)
    {
        if (other.CompareTag("Candy")) 
        {
            
            score += 10;
            UpdateScoreText();

            
            Destroy(other.gameObject);
        }
    }

    
    void Update()
    {
        
    }
}
