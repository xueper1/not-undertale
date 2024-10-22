using UnityEngine;
using UnityEngine.UI; 
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 
    private int score = 0;

    public void AddScore(int points)
    {
        score += points; 
        UpdateScoreText(); 
    }


    private void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
