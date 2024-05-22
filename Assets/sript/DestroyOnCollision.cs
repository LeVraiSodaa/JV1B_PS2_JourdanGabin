using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    // Fonction appelée lorsque le joueur entre en collision avec un objet
    void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet en collision a le tag "Player"
        if (other.CompareTag("Player"))
        {
            // Détruire l'objet en collision
            Destroy(gameObject);

            // Charger la nouvelle scène
            SceneManager.LoadScene(0);
        }
    }
}
