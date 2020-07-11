using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [SerializeField] AudioClip targetBreakAudio;

    Level level;

    public int targetHitPoints;

    private void Start()
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableTarget();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ball")
        {
            AudioSource.PlayClipAtPoint(targetBreakAudio, Camera.main.transform.position);
        }
        DestroyTarget();
        FindObjectOfType<GameStatus>().AddToScore();
        FindObjectOfType<TargetSpawner>().SpawnTarget();
    }

    private void DestroyTarget()
    {
        Destroy(gameObject);
    }
   
}
