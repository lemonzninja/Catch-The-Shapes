using _Scripts.GameObjets.Player;
using TMPro;
using UnityEngine;

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
    }
}