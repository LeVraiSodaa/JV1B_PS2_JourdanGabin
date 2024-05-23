using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetection : MonoBehaviour
{
    public string targetSceneName; // Nom de la sc�ne cible � changer, assign� depuis l'inspecteur

    // Fonction appel�e lorsque le joueur entre en collision avec un objet
    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si l'objet en collision a le tag "Player"
        if (other.CompareTag("Player"))
        {
            // D�truire l'objet en collision
            Destroy(gameObject);

            // Charger la nouvelle sc�ne
            if (!string.IsNullOrEmpty(targetSceneName))
            {
                Debug.Log("Changing scene to " + targetSceneName + "...");
                SceneManager.LoadScene(targetSceneName); // Charger la sc�ne sp�cifi�e par le nom
            }
            else
            {
                Debug.LogWarning("Target scene name is not assigned!");
            }
        }
    }
}
