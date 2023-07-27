using UnityEngine;

namespace _Scripts.GameObjets.Player
{
    public class PlayerController : MonoBehaviour
    {
    
        // The speed of the player
        [SerializeField] private float moveSpeed = 5.0f;
        // The screen bounds
        [SerializeField] private float screenBounds;
    
        private Vector3 _playerPos;
        private Vector3 _position;
        private Transform _transform;
    
        private void Start()
        {
            // Get the transform component
            _transform = GetComponent<Transform>();
            _position = _transform.position;
        }
    
        public void MovePlayer()
        {
            // Get left and right input.
            var horizontalInput = Input.GetAxis("Horizontal");
        
            // move the player left and right
            _position.x += horizontalInput * moveSpeed * Time.deltaTime;
            _transform.position = _position;
        
            // Restrict the player from leaving the screen
            _playerPos = _position;
            var xPos = Mathf.Clamp(_playerPos.x, -screenBounds, screenBounds);
            _playerPos = new Vector3(xPos, _playerPos.y, _playerPos.z);
            _position = _playerPos;
        }
    }
}