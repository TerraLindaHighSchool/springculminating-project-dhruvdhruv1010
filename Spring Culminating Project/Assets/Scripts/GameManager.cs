using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    
    public bool isGameActive = true;
    public TextMeshProUGUI scoreText;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        isGameActive = true;
        scoreText.text = "Score: " + score;
    }

    void updateScore()
    {
        score = (int)Time.time * 100;
    }

    void StartGame()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        updateScore();
        scoreText.text = "Score: " + score;
    }
    
}