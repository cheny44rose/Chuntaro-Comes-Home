using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    public int PlayerScore;
    public Text Score;
    public bool toReturn;
    public GameObject gameOverScreen;
    public GameObject gameStartScreen;
    public bool gameDone;
    [ContextMenu("Increase Score")]
    public void addScore(int toAdd){
        PlayerScore = PlayerScore + toAdd;
        Score.text = PlayerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        gameDone  =  true;
    }

    public void gameStart()
    {
        gameStartScreen.SetActive(false);
        toReturn = true;
    }

    public bool start()
    {
        if (toReturn && !gameDone)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
