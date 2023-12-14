using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] coinPrefabsArray;
    private int coinIndex;

    public Vector3 spawnAreaSize = new Vector3(9f, 0f, 6f);


    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomCoin", startDelay, spawnInterval);
    }

    private void SpawnRandomCoin()
    {
        coinIndex = Random.Range(0, coinPrefabsArray.Length);

        float randomX = Random.Range(-spawnAreaSize.x / 2, spawnAreaSize.x / 2);
        float randomZ = Random.Range(-spawnAreaSize.z / 2, spawnAreaSize.z / 2);

        Vector3 randomSpawnPos = transform.position + new Vector3(randomX, 0f, randomZ);

        Instantiate(coinPrefabsArray[coinIndex], randomSpawnPos, Quaternion.identity);
    }

    

}
