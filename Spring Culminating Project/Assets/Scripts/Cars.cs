using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Cars : MonoBehaviour
{
    public bool isGameActive = true;
    public GameObject[] carPrefabs;
    private float spawnRangeX = 21;
    private float spawnPosZ = 55;
    private float startDelay = 1;
    private float spawnInterval = 0.7f;
    private float lowerBound = -15;
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCarLeftSide", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomCarRightSide", startDelay, spawnInterval);
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {
        DestroyOutOfBounds();
        MoveForward();
    }
    void DestroyOutOfBounds()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
    void MoveForward()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            endGame();
            
        }
    }

    void endGame()
    {
        isGameActive = false;
        Debug.Log("h");
        //CancelInvoke("SpawnRandomCarLeftSide");
        //CancelInvoke("SpawnRandomCarRightSide");
    }
    void SpawnRandomCarLeftSide()
    {
        //if (isGameActive)
        //{
            int carIndex = Random.Range(0, carPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, -2), 2, spawnPosZ);
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
        //}
    }


    void SpawnRandomCarRightSide()
    {
        //if (isGameActive)
        //{
            int carIndex = Random.Range(0, carPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(2, spawnRangeX), 2, spawnPosZ);
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
        //}
    }
}
