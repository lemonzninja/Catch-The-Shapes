using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class ScoreManager : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI scoreText;
        
        private float _score;
        
        private void Start()
        {
            scoreText.text = "Score: " + _score;
        }
        
        public void AddScore(float scoreToAdd)
        {
            _score += scoreToAdd;
            scoreText.text = "Score: " + _score;
        }
    }
}