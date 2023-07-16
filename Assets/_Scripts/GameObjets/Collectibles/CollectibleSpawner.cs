using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
    // Reference to the StartButton script
    private StartButton _startButtonScript;
    
    // A array of collectibles
    [SerializeField] private GameObject[] _collectiblesObjectsArray;
    
    // the spawn position
    public float _spawnPos;
    
    private Transform _transform;
    private Vector3 _position;
    
    private void Start()
    {
        // Get the transform component
        _transform = GetComponent<Transform>();
        _position = _transform.position;
    
        _startButtonScript = GameObject.Find("StartButton").GetComponent<StartButton>();
        
        InvokeRepeating(nameof(SpawnCollectibles), 2, 2);
    }

    public void SpawnCollectibles()
    {
        // Check if the game has started
        if (_startButtonScript.gameStarted)
        {
            // Get a random collectible
            var randomCollectible = Random.Range(0, _collectiblesObjectsArray.Length);
            // Spawn the collectible
            Instantiate(_collectiblesObjectsArray[randomCollectible], new Vector3(Random.Range(-_spawnPos, _spawnPos), _position.y, _position.z), Quaternion.identity);
        }
    }
}