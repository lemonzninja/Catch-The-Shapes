using System;
using UnityEngine;

public class Collectible : MonoBehaviour
{
	// Get the GameManager component
	private GameManager _gameManager;

	[SerializeField] private float _scoreToAdd = 1.0f;
	
	private void Start()
	{
		// Get the GameManager component
		_gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
	}

	// Check if 2d box collider is colliding with the player
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Check if the player is colliding with the collectible
		if (other.gameObject.CompareTag("Player"))
		{
			// Destroy the collectible
			Destroy(gameObject);
			
			// add to the score
			_gameManager.AddScore(_scoreToAdd);
		}
	}
}