using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Instance du singleton
    public Text blueObjectsDestroyedText; // Référence au texte UI pour afficher le compteur

    private int blueObjectsDestroyed = 0; // Compteur d'objets "Blue" détruits

    void Awake()
    {
        // Assurer qu'il n'y a qu'une seule instance du GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Ne pas détruire cet objet lors du changement de scène
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Initialiser le texte UI au démarrage
        UpdateUI();
    }

    // Fonction pour augmenter le compteur d'objets "Blue" détruits
    public void IncreaseBlueObjectCount()
    {
        blueObjectsDestroyed++;
        Debug.Log("Blue Objects Destroyed: " + blueObjectsDestroyed);

        // Mettre à jour le texte UI
        UpdateUI();
    }

    // Fonction pour mettre à jour le texte UI avec le compteur actuel
    void UpdateUI()
    {
        if (blueObjectsDestroyedText != null)
        {
            blueObjectsDestroyedText.text = "Blue Objects Destroyed: " + blueObjectsDestroyed;
        }
    }
}
