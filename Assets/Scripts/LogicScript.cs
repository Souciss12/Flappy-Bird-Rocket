using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool birdAlive = true;
    public AudioSource dingSFX;

    [ContextMenu("Increase Score")]
    public void addScore(int addScore)
    {
        if (birdAlive)
        {
            dingSFX.Play();
            playerScore += addScore;
            scoreText.text = playerScore.ToString();
        }
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        birdAlive = false;
    }
}
