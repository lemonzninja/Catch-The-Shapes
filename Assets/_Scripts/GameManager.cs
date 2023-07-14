using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private StartButton _startButton;
    
    private CollectibleSpawner _collectibleSpawner;
    
    // Reference to the title UI
    [SerializeField] private GameObject _titlerUI;
    // Reference to the Game UI
    [SerializeField] private GameObject _gameUI;
    
    // Score
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
                // Hide the title UI and show the game UI
                _titlerUI.SetActive(false);
                // Show the game UI
                _gameUI.SetActive(true);
         }
    }
    
    // A function to add to the score
    public void AddScore(float scoreToAdd)
    {
        // Add to the score
        _score += scoreToAdd;
        // Update the score text
        _scoreText.text = "" + _score;
    }
}