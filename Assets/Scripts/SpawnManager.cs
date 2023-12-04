using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] coinPrefabsArray;
    private int coinIndex;

    private float spawnRangeX = 9f;
    private float spawnPosZ = 6f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomCoin", startDelay, spawnInterval);
    }

    private void SpawnRandomCoin()
    {
        coinIndex = Random.Range(0, coinPrefabsArray.Length);
        Instantiate(coinPrefabsArray[coinIndex], RandomSpawnPos(), Quaternion.Euler(0, 0, 0));
    }

    private Vector3 RandomSpawnPos()
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);
    }

}
