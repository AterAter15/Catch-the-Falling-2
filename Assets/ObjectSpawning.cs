using System;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // List of prefabs to spawn (fruit, bomb, etc.)
    public float spawnInterval = 1f; // Time between spawns
    public float xRange = 8f; // Horizontal range for spawning

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval); // Spawn repeatedly
    }

    void SpawnObject()
    {
        int randomIndex = UnityEngine.Random.Range(0, objectsToSpawn.Length);
        float randomX = UnityEngine.Random.Range(-xRange, xRange);

        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);
        Instantiate(objectsToSpawn[randomIndex], spawnPosition, Quaternion.identity);
    }
}
