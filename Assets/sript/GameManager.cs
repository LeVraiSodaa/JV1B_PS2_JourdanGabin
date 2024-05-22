using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; // Instance du singleton
    public Text blueObjectsDestroyedText; // R�f�rence au texte UI pour afficher le compteur

    private int blueObjectsDestroyed = 0; // Compteur d'objets "Blue" d�truits

    void Awake()
    {
        // Assurer qu'il n'y a qu'une seule instance du GameManager
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Ne pas d�truire cet objet lors du changement de sc�ne
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // Initialiser le texte UI au d�marrage
        UpdateUI();
    }

    // Fonction pour augmenter le compteur d'objets "Blue" d�truits
    public void IncreaseBlueObjectCount()
    {
        blueObjectsDestroyed++;
        Debug.Log("Blue Objects Destroyed: " + blueObjectsDestroyed);

        // Mettre � jour le texte UI
        UpdateUI();
    }

    // Fonction pour mettre � jour le texte UI avec le compteur actuel
    void UpdateUI()
    {
        if (blueObjectsDestroyedText != null)
        {
            blueObjectsDestroyedText.text = "Blue Objects Destroyed: " + blueObjectsDestroyed;
        }
    }
}
