using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreUIText;
    public GameObject gameOver;


    [ContextMenu("Increase Score")]
    public void AddScore(int score)
    {
        playerScore += score;
        scoreUIText.text = playerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
    }
}
