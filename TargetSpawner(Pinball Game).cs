using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawner : MonoBehaviour
{
    int randomTarget;

    public GameObject[] targetPrefab;

    // Update is called once per frame

    public void SpawnTarget()
    {
        var targetSpawnPos = new Vector2(Random.Range(2.83f, 5.28f), Random.Range(8.74f, 3.88f));
        randomTarget = Random.Range(0, 3);
        Instantiate(targetPrefab[randomTarget], targetSpawnPos, Quaternion.identity);
    }

}
