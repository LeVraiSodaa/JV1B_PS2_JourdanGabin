using UnityEngine;

public class ShowSpriteOnCollision : MonoBehaviour
{
    public GameObject uiElement; // R�f�rence � l'�l�ment UI � afficher

    void OnTriggerEnter2D(Collider2D other)
    {
        // V�rifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // Active l'�l�ment UI
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
        // V�rifie si l'objet en collision est le joueur
        if (other.CompareTag("Player"))
        {
            // D�sactive l'�l�ment UI
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
