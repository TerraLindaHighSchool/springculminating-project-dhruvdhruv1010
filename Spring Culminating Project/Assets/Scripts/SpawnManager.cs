using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 21;
    private float spawnPosZ = 55;
    private float startDelay = 1;
    public float spawnInterval = 0.7f;
    void Start()
    {
        InvokeRepeating("SpawnRandomCarLeftSide", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomCarRightSide", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomCarLeftSide()
    {
        int carIndex = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, -2), 2, spawnPosZ);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }


    void SpawnRandomCarRightSide()
    {
        int carIndex = Random.Range(0, carPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(2, spawnRangeX), 2, spawnPosZ);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
