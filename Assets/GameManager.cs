using UnityEngine;
using TMPro;
using System.Diagnostics;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    private int score = 0;
    public float gameTime = 60f;

    void Awake()
    {
        instance = this; // Singleton pattern
    }

    void Update()
    {
        gameTime -= Time.deltaTime; // Update timer
        timerText.text = "Time: " + Mathf.CeilToInt(gameTime);

        if (gameTime <= 0)
        {
            //Debug.Log("Time's up! Game Over.");
            
            // Implement game over logic
        }
    }

    public void AddScore(int value)
    {
        score += value;
        scoreText.text = "Score: " + score;
    }
}
