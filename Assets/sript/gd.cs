using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyKillCounter : MonoBehaviour
{
    private int enemyCount = 0; // Compteur d'ennemis détruits
    private int requiredEnemyCount = 3; // Nombre d'ennemis requis pour activer le changement de scène
    public Text enemyCountText; // Référence au texte UI
    private bool canChangeScene = false; // Indicateur pour permettre le changement de scène

    void Start()
    {
        UpdateEnemyCountText();
    }

    // Méthode pour augmenter le compteur d'ennemis
    public void EnemyDestroyed()
    {
        enemyCount++;
        Debug.Log("Enemy destroyed. Current count: " + enemyCount);
        UpdateEnemyCountText();

        // Vérifier si le nombre requis d'ennemis a été détruit
        if (enemyCount >= requiredEnemyCount)
        {
            canChangeScene = true; // Activer le changement de scène
            Debug.Log("You can now press V to change the scene.");
        }
    }

    void Update()
    {
        // Vérifier si la touche "V" est enfoncée et si le changement de scène est activé
        if (canChangeScene && Input.GetKeyDown(KeyCode.V))
        {
            ChangeScene();
        }
    }

    // Méthode pour changer de scène
    private void ChangeScene()
    {
        Debug.Log("Changing scene...");
        SceneManager.LoadScene(1); // Remplacer par le nom de la scène cible
    }

    // Méthode pour mettre à jour le texte UI
    private void UpdateEnemyCountText()
    {
        if (enemyCountText != null)
        {
            enemyCountText.text = "Enemies Eliminated: " + enemyCount;
        }
        else
        {
            Debug.LogWarning("Enemy count text UI is not assigned!");
        }
    }
}
