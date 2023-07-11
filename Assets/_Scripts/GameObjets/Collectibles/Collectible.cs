using UnityEngine;

public class Collectible : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 3.0f;
	
	
	private void Update()
	{
		// Move the collectible down
		transform.Translate(Vector3.down * (_moveSpeed * Time.deltaTime));
		
		// Check if the collectible is off the screen
		if (transform.position.y < -6.0f)
		{
			// Destroy the collectible
			Destroy(gameObject);
		}
	}
}