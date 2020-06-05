using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CarController : MonoBehaviour
{
    private float lowerBound = -15;
    public float speed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
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
        this.speed = 0;
        Time.timeScale = 0;
    }
}
