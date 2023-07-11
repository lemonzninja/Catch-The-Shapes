using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StartButton _startButton;
    
    // Reference to the title UI
    [SerializeField] private GameObject _titlerUI;
    // Reference to the Game UI
    [SerializeField] private GameObject _gameUI;
    
    
    private float _score = 0.0f;
    [SerializeField] private TextMeshProUGUI _scoreText;
    
   private void Start()
   {
       // Get the StartButton component
       _startButton = GameObject.Find("StartButton").GetComponent<StartButton>();
   

   }

    private void Update()
    {
         // Check if the game has started
         if (_startButton.gameStarted)
         {   
                _titlerUI.SetActive(false);
                _gameUI.SetActive(true);
         }
    }
}