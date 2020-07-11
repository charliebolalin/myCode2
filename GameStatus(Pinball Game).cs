using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameStatus : MonoBehaviour
{
    [Range(0.5f, 1f)] [SerializeField] float gameSpeed;

    [SerializeField] public Text scoreText;

    public int currentScore = 0;
  
    // Start is called before the first frame update

    private void Awake()
    {

        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if (gameStatusCount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
   

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += FindObjectOfType<Target>().targetHitPoints;
        scoreText.text = currentScore.ToString();

    }

    public void ResetScore()
    {
        currentScore = 0; 
        scoreText.text = currentScore.ToString();
    }

  

}
