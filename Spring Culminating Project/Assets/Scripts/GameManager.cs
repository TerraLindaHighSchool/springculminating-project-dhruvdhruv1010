using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 21;
    private float spawnPosZ = 55;
    private float startDelay = 2;
    private float spawnInterval = 0.7f;
    private float lowerBound = -15;
    public float speed = 40.0f;
    public bool isGameActive;
    public TextMeshProUGUI gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true;
        InvokeRepeating("spawnRandomCarLeftSide", startDelay, spawnInterval);
        InvokeRepeating("spawnRandomCarRightSide", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        destroyOutOfBounds();
        moveForward();
    }
    void destroyOutOfBounds()
    {
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
    void moveForward()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        isGameActive = false;
    }
    void spawnRandomCarLeftSide()
    {
        if (isGameActive)
        {
            int carIndex = Random.Range(0, carPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, -2), 2, spawnPosZ);
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
        }
    }
    void spawnRandomCarRightSide()
    {
        if (isGameActive)
        {
            int carIndex = Random.Range(0, carPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(2, spawnRangeX), 2, spawnPosZ);
            Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
        }
    }
}
