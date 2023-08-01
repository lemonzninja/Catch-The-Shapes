using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Scripts.GameObjets.Collectibles
{
    public class CollectibleSpawner : MonoBehaviour
    {
        // Reference to the StartButton script
        private StartButton _startButtonScript;
    
        // A array of collectibles
        [SerializeField] private GameObject[] collectiblesObjectsArray;
    
        // the spawn position
        public float spawnPos;
        
        // The delay before the collectible spawn
        [SerializeField] private float startDelay =.5f;
        // The time between each collectible spawn
        [SerializeField] private float repeatRate = 2f;

        private float spawnInNSeconds = 0f;
        
        // The min and max spawn interval
        [SerializeField] private float minSpawnInterval = 0f;
        // The max spawn interval
        [SerializeField] private float maxSpawnInterval = 1f;
        
        private Transform _transform;
        private Vector3 _position;
    
        private void Start()
        {
            // Get the transform component
            _transform = GetComponent<Transform>();
            _position = _transform.position;
    
            _startButtonScript = GameObject.Find("StartButton").GetComponent<StartButton>();
        
            spawnInNSeconds = Random.Range(minSpawnInterval, maxSpawnInterval);
            
            InvokeRepeating(nameof(SpawnCollectibles), startDelay, spawnInNSeconds);
        }
        

        public void SpawnCollectibles()
        {
            // Check if the game has started
            if (_startButtonScript.gameStarted)
            {
                // Get a random collectible
                var randomCollectible = Random.Range(0, collectiblesObjectsArray.Length);
                // Spawn the collectible
                Instantiate(collectiblesObjectsArray[randomCollectible], new Vector3(Random.Range(-spawnPos, spawnPos), _position.y, _position.z), Quaternion.identity);
                
                spawnInNSeconds = Random.Range(minSpawnInterval, maxSpawnInterval);
            }
        }
    }
}