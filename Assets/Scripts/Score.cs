using UnityEngine;

public class DestroyOnCollision2D : MonoBehaviour
{
    public ScoreManager scoreManager;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Проверяем, если объект, с которым столкнулся текущий объект, имеет тег "Player"
        if (collision.gameObject.tag == "Player")
        {
            scoreManager.AddScore(1);
            Destroy(gameObject);
        }
    }
}
