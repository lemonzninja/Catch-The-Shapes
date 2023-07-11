using UnityEngine;

public class Collectible : MonoBehaviour
{
	private void Update()
	{
		
		// Check if the collectible is off the screen
		if (transform.position.y < -6.0f)
		{
			// Destroy the collectible
			Destroy(gameObject);
		}
	}
	
	// Check if 2d box collider is colliding with the player
	private void OnTriggerEnter2D(Collider2D other)
	{
		// Check if the player is colliding with the collectible
		if (other.gameObject.CompareTag("Player"))
		{
			// Destroy the collectible
			Destroy(gameObject);

			Debug.Log("Hit");
		}
	}
}