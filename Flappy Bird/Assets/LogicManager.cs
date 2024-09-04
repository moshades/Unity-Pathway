using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour
{
    public int playerScore;
    public AudioSource pointSFX;
    public Bird bird;
    public GameObject gameOverScreen;
    public Text scoreText;
    public bool isGameOver;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        pointSFX.Play();
    }

    public void menuReturn()
    {
        SceneManager.LoadSceneAsync("Tittle Scene");
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        bird.GetComponent<CircleCollider2D>().enabled = false;
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }
}
