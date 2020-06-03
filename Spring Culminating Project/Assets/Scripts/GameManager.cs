using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    private Button button;
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(StartGame);
        StartGame();
    }

    void StartGame()
    {
        isGameActive = true;
        
        titleScreen.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        isGameActive = false;
    }
    
}