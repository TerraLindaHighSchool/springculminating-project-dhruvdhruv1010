using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cars : MonoBehaviour
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
}
