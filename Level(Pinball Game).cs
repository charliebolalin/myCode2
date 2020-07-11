using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level : MonoBehaviour
{
    [SerializeField] int countTarget;

    [SerializeField] int scoreGoalToLoadNextScene;

    GameStatus gameStatus;


    private void Start()
    {
        gameStatus = FindObjectOfType<GameStatus>();
    }
    private void Update()
    {
        LoadNextLevel();
    }
    public void CountBreakableTarget()
    {
        countTarget++;
    }

    private void LoadNextLevel()
    {

        if (gameStatus.currentScore == scoreGoalToLoadNextScene)
        {
            SceneManager.LoadScene(1);
        }
    }
    
    public void LoadStartGame()
    {
        SceneManager.LoadScene(0);
    }

}
