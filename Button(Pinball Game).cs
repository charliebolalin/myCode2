using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject playAgainButton;

    GameStatus gameStatus;

    Spike spike;

    Ball ball;

    bool isResetted = false;

    // Start is called before the first frame update
    void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
        spike = FindObjectOfType<Spike>();
        ball = FindObjectOfType<Ball>();
        playAgainButton.gameObject.SetActive(false);
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
        playAgainButton.gameObject.SetActive(false);
        isResetted = true;

        if (isResetted)
        {
            gameStatus.ResetScore();
            spike.gameOverText.enabled = false;
            ball.pressEnterText.enabled = true;
        }
       

    }

}
