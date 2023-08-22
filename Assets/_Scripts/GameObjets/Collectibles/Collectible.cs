using System;
using _Scripts;
using UnityEngine;

public class Collectible : MonoBehaviour
{
	// Get the ScoreManager component
    private ScoreManager _scoreManager;
	
	[SerializeField] private float _scoreToAdd = 1.0f;
	
	private void Start()
	{
		// Get the ScoreManager component
		_scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
	}

	// Check if 2d box collider is colliding with the player
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Check if the player is colliding with the collectible
		if (other.gameObject.CompareTag("Player"))
		{
			// Destroy the collectible
			Destroy(gameObject);
            
			// Add to the score
			_scoreManager.AddScore(_scoreToAdd);
		}
	}
}