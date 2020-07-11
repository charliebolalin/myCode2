using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spike : MonoBehaviour
{
    public Text gameOverText;

    Button button;

    private void Start()
    {
        button = FindObjectOfType<Button>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<AudioSource>().Play();
        gameOverText.text = "Game Over";
        button.playAgainButton.SetActive(true);
    }
}
