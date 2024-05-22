using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyKillCounter : MonoBehaviour
{
    private int enemyCount = 0; // Compteur d'ennemis d�truits
    private int requiredEnemyCount = 3; // Nombre d'ennemis requis pour activer le changement de sc�ne
    public Text enemyCountText; // R�f�rence au texte UI
    private bool canChangeScene = false; // Indicateur pour permettre le changement de sc�ne

    void Start()
    {
        UpdateEnemyCountText();
    }

    // M�thode pour augmenter le compteur d'ennemis
    public void EnemyDestroyed()
    {
        enemyCount++;
        Debug.Log("Enemy destroyed. Current count: " + enemyCount);
        UpdateEnemyCountText();

        // V�rifier si le nombre requis d'ennemis a �t� d�truit
        if (enemyCount >= requiredEnemyCount)
        {
            canChangeScene = true; // Activer le changement de sc�ne
            Debug.Log("You can now press V to change the scene.");
        }
    }

    void Update()
    {
        // V�rifier si la touche "V" est enfonc�e et si le changement de sc�ne est activ�
        if (canChangeScene && Input.GetKeyDown(KeyCode.V))
        {
            ChangeScene();
        }
    }

    // M�thode pour changer de sc�ne
    private void ChangeScene()
    {
        Debug.Log("Changing scene...");
        SceneManager.LoadScene(1); // Remplacer par le nom de la sc�ne cible
    }

    // M�thode pour mettre � jour le texte UI
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
