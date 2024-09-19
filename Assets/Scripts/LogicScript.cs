using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public GameObject gameOverScreen;
    public AudioManager aud;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        if(aud != null)
           aud.PlayScoreSound();

        playerScore++;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        if(aud != null)
            aud.PlayGameOverSound();

        aud = null;
        gameOverScreen.SetActive(true);
       

    }
}
