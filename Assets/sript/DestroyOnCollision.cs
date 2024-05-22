using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    // Fonction appel�e lorsque le joueur entre en collision avec un objet
    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si l'objet en collision a le tag "Player"
        if (other.CompareTag("Player"))
        {
            // D�truire l'objet en collision
            Destroy(gameObject);

            // Charger la nouvelle sc�ne
            SceneManager.LoadScene(0);
        }
    }
}
