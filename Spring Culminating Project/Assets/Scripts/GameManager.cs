using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //public TextMeshProUGUI gameOverText;
    //public Button startButton;
    //public GameObject titleScreen;
    //public Cars Cs;

    // Start is called before the first frame update
    void Start()
    {
        //startButton = GetComponent<Button>();
        //startButton.onClick.AddListener(StartGame);
    }

    void StartGame()
    {
        //Cs.isGameActive = true;
        //titleScreen.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //Cs.isGameActive = false;
    }
    
}