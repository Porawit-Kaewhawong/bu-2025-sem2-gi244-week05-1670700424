using UnityEngine;

[System.Serializable]
public class Wave // This script is meant for sub-class
{
    public GameObject[] enemyPrefabs;
    public int enemyCount;
    public float spawnInterval;
    public int waveInterval;
}