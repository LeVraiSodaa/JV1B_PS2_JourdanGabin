using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Si le joueur entre en collision avec le triangle
        if (collision.gameObject.CompareTag("triangle"))
        {
            // Relance la scène actuelle
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Relance la scène actuelle
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
    }
}
