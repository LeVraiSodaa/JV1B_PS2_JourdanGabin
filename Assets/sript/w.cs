using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int requiredEliminations = 3; // Nombre d'ennemis à tuer pour permettre le changement de scène
    public string nextSceneName = "Scene1"; // Nom de la scène à charger après avoir tué le nombre requis d'ennemis

    private int eliminationCount = 0; // Compteur d'éliminations

    // Fonction pour augmenter le compteur d'éliminations
    public void IncreaseEliminationCount()
    {
        eliminationCount++;
        Debug.Log("Elimination count increased: " + eliminationCount);

        // Vérifier si le nombre requis d'éliminations est atteint
        if (eliminationCount >= requiredEliminations)
        {
            ChangeScene();
        }
    }

    // Fonction pour changer de scène
    private void ChangeScene()
    {
        Debug.Log("Changing scene to: " + nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }
}
