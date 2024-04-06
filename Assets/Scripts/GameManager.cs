using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int score = 0;
    public int lives = 3;
    public bool gamePaused = false;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
    }

    public void AddScore(int points)
    {
        score += points;
        // Update UI or trigger other actions based on score change
    }

    public void LoseLife()
    {
        lives--;
        // Update UI or trigger other actions based on life loss
        if (lives <= 0)
            GameOver();
    }

    void GameOver()
    {
        // Handle game over logic, such as displaying game over screen, restarting the game, etc.
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gamePaused = true;
        // Show pause menu or other UI elements
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        gamePaused = false;
        // Hide pause menu or other UI elements
    }

    public void RestartLevel()
    {
        // Implement logic to restart the current level
    }
}
