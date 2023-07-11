using System;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
	[SerializeField] private float _moveSpeed = 3.0f;


	private void Update()
	{
		// Move the collectible down
		transform.Translate(Vector3.down * (_moveSpeed * Time.deltaTime));
	}
}