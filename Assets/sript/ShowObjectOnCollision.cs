using UnityEngine;

public class ShowSpriteOnCollision : MonoBehaviour
{
    public SpriteRenderer otherSpriteRenderer; // Référence au SpriteRenderer de l'objet à afficher

    void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Change l'opacité du SpriteRenderer de l'objet à afficher à 100%
            if (otherSpriteRenderer != null)
            {
                Color newColor = otherSpriteRenderer.color;
                newColor.a = 1.0f; // Opacité à 100%
                otherSpriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogWarning("Other SpriteRenderer is not assigned!");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Vérifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Change l'opacité du SpriteRenderer de l'objet à afficher à 0%
            if (otherSpriteRenderer != null)
            {
                Color newColor = otherSpriteRenderer.color;
                newColor.a = 0.0f; // Opacité à 0%
                otherSpriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogWarning("Other SpriteRenderer is not assigned!");
            }
        }
    }
}
