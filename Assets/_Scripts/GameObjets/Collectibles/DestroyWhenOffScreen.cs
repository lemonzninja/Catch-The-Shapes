using UnityEngine;

public class DestroyWhenOffScreen : MonoBehaviour
{
	private void Update()
	{
		// Check if the GameObject is off the screen
		if (transform.position.y < -6.0f)
		{
			// Destroy the collectible
			Destroy(gameObject);
		}
	}
}