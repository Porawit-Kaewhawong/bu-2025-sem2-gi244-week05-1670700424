using UnityEngine;

public class WaveController : MonoBehaviour
{
    public Wave currentWave;
    public Transform[] spawnPoints;

    private int enemySpawned = 0;
    private float nextSpawnTime = 0;

    void Update()
    {
        // Create a new variable "t" to start a timer
        var t = Time.time;

        // If "t" is higher than "nextSpawnTime" and "enemySpawned" is lower than "currentWave.enemyCount"
        if (t > nextSpawnTime && enemySpawned < currentWave.enemyCount)
        {
            // Run "Spawn()" method
            Spawn();

            // Add "enemySpawned" count by 1 permanently
            enemySpawned++;

            // Set "nextSpawnTime" to start a timer with "currentWave.spawnInterval"
            nextSpawnTime = Time.time + currentWave.spawnInterval;
        }
    }

    public void ChangeWave(Wave wave)
    {
        currentWave = wave;

        enemySpawned = 0;
        nextSpawnTime = Time.time;
    }

    public bool isCompeleted()
    {
        return enemySpawned >= currentWave.enemyCount;
    }

    void Spawn()
    {
        // Create a new variable "enemyIndex" and randomize the range between 0 to enemyPrefabs length
        int enemyIndex = Random.Range(0, currentWave.enemyPrefabs.Length);

        // Create a new variable "spawnPointIndex" and randomize the range between 0 to spawnPoints length
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        // Instantiate using "enemyPrefabs" with "enemyIndex" at "spawnPoints"'s position with "spawnPointIndex" with prefab's own rotation
        Instantiate(
            currentWave.enemyPrefabs[enemyIndex], 
            spawnPoints[spawnPointIndex].position, 
            currentWave.enemyPrefabs[enemyIndex].transform.rotation);
    }
}
