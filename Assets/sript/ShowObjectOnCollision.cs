using UnityEngine;

public class ShowSpriteOnCollision : MonoBehaviour
{
    public SpriteRenderer otherSpriteRenderer; // R�f�rence au SpriteRenderer de l'objet � afficher

    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Change l'opacit� du SpriteRenderer de l'objet � afficher � 100%
            if (otherSpriteRenderer != null)
            {
                Color newColor = otherSpriteRenderer.color;
                newColor.a = 1.0f; // Opacit� � 100%
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
        // V�rifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Change l'opacit� du SpriteRenderer de l'objet � afficher � 0%
            if (otherSpriteRenderer != null)
            {
                Color newColor = otherSpriteRenderer.color;
                newColor.a = 0.0f; // Opacit� � 0%
                otherSpriteRenderer.color = newColor;
            }
            else
            {
                Debug.LogWarning("Other SpriteRenderer is not assigned!");
            }
        }
    }
}
