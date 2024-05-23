using UnityEngine;

public class ShowSpriteOnCollision : MonoBehaviour
{
    public GameObject uiElement; // Référence à l'élément UI à afficher

    void OnTriggerEnter2D(Collider2D other)
    {
        // Vérifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Active l'élément UI
            if (uiElement != null)
            {
                uiElement.SetActive(true);
            }
            else
            {
                Debug.LogWarning("UI Element is not assigned!");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        // Vérifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Désactive l'élément UI
            if (uiElement != null)
            {
                uiElement.SetActive(false);
            }
            else
            {
                Debug.LogWarning("UI Element is not assigned!");
            }
        }
    }
}
