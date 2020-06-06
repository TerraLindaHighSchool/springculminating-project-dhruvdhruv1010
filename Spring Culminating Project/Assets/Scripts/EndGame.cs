using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI finalScoreText;
    void Start()
    {
        GameObject scoreText = GameObject.Find("ScoreText");
        GameManager gameManager = scoreText.GetComponent<GameManager>();
        finalScoreText.text = "Game Over! Score: " + gameManager.score;

    }
}
