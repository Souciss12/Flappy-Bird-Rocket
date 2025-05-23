using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public int munition;
    public Text scoreText;
    public GameObject gameOverScreen;
    public bool birdAlive = true;
    public AudioSource dingSFX;
    public ParticleSystem missileExplosionSFX;
    public ParticleSystem birdExplosionSFX;
    public AudioSource buttonSound;

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

    public void missileExplosion(Transform missileTransform)
    {
        missileExplosionSFX.transform.position = missileTransform.position;
        missileExplosionSFX.Play();
    }

    public void birdExplosion(Transform birdTransform)
    {
        birdExplosionSFX.transform.position = birdTransform.position;
        birdExplosionSFX.Play();
    }

    public void button()
    {
        buttonSound.Play();
    }

    public void addMunition()
    {
        munition++;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
