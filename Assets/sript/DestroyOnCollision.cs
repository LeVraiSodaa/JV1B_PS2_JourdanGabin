using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public string targetSceneName; // Nom de la scène cible à changer, assigné depuis l'inspecteur

    // Fonction appelée lorsque le joueur entre en collision avec un objet
    void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet en collision a le tag "Player"
        if (other.CompareTag("Player"))
        {
            // Détruire l'objet en collision
            Destroy(gameObject);

            // Charger la nouvelle scène
            if (!string.IsNullOrEmpty(targetSceneName))
            {
                Debug.Log("Changing scene to " + targetSceneName + "...");
                SceneManager.LoadScene(targetSceneName); // Charger la scène spécifiée par le nom
            }
            else
            {
                Debug.LogWarning("Target scene name is not assigned!");
            }
        }
    }
}
