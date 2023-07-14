using UnityEngine;

public class CollectibleSpawner : MonoBehaviour
{
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
        
        InvokeRepeating(nameof(SpawnCollectibles), 2, 2);
    }

    public void SpawnCollectibles()
    {
        // Pick a random collectible from the array
        var randomCollectible = Random.Range(0, _collectiblesObjectsArray.Length);
        
        // pick a random position to spawn the collectible
        var randomPos = Random.Range(-_spawnPos, _spawnPos);
        
        // Spawn the collectible
        Instantiate(_collectiblesObjectsArray[randomCollectible], new Vector3(randomPos, _position.y, _position.z), Quaternion.identity);
    }
}