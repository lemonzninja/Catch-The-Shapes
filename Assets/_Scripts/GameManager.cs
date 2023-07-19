using TMPro;
using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts
{
    public class GameManager : MonoBehaviour
    {
        // Reference to the StartButton component
        private StartButton _startButton;
        // Reference to the PlayerController component
        private PlayerController _playerController;
    
        // Reference to the title UI
        [SerializeField] private GameObject titleUI;
        // Reference to the Game UI
        [SerializeField] private GameObject gameUI;
    
        // The player object
        [SerializeField] private GameObject player;
        
        // Score
        private float _score = 0.0f;
        [SerializeField] private TextMeshProUGUI scoreText;
        
        private void Start()
        {
            // Get the StartButton component
            _startButton = GameObject.Find("StartButton").GetComponent<StartButton>();
            
            // Get the PlayerController component
            _playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        }
    
        private void Update()
        {
            // Check if the game has started
            if (_startButton.gameStarted)
            {   
                // Hide the title UI and show the game UI
                titleUI.SetActive(false);
                // Show the game UI
                gameUI.SetActive(true);
                
                // Show the player
                player.GetComponent<Renderer>().enabled = true;
                
                // Allow the player to move
                _playerController.MovePlayer();
            }
        }
    
        // A function to add to the score
        public void AddScore(float scoreToAdd)
        {
            // Add to the score
            _score += scoreToAdd;
            // Update the score text
            scoreText.text = "" + _score;
        }
    }
}