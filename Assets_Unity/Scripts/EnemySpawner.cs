using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public float spawnRatePerMinute = 30f;
    public float spawnRateIncrement = 1f;
    public float maxTimeLife = 4f;

    public float spawnNext = 0;

    void Update()
    {
        if (Time.time >= 1f && Time.time > spawnNext){
            spawnNext = Time.time * 60 / spawnRatePerMinute;
            spawnRatePerMinute += spawnRateIncrement;

            float rand = Random.Range(-5, 5);
            Vector2 spawnPosition = new Vector2(rand, 7f);
            GameObject meteor = Instantiate(asteroidPrefab, spawnPosition, Quaternion.identity);

            Destroy(meteor, maxTimeLife);
        }
    }
}
