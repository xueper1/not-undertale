using UnityEngine;
using UnityEngine.UI; 
using TMPro; 
using UnityEngine.SceneManagement;
public class ObjectMissed : MonoBehaviour
{
    public float boundaryY = -5f;
    public GameObject gameOverScreen;
    public TextMeshProUGUI gameOverText;
    public ScoreManager scoreManager; 

    private bool isGameOver = false; 

    void Update()
    {
        
        if (transform.position.y < boundaryY && !isGameOver)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        isGameOver = true;


        if (gameOverScreen != null)
        {
            gameOverScreen.SetActive(true); 
        }


        if (gameOverText != null)
        {
            gameOverText.text = "Game Over!";
            RestartGame();
        }



        Time.timeScale = 0f; 
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;  
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
