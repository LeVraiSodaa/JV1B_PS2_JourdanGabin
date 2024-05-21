using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public int requiredEliminations = 3; // Nombre d'ennemis � tuer pour permettre le changement de sc�ne
    public string nextSceneName = "Scene1"; // Nom de la sc�ne � charger apr�s avoir tu� le nombre requis d'ennemis

    private int eliminationCount = 0; // Compteur d'�liminations

    // Fonction pour augmenter le compteur d'�liminations
    public void IncreaseEliminationCount()
    {
        eliminationCount++;
        Debug.Log("Elimination count increased: " + eliminationCount);

        // V�rifier si le nombre requis d'�liminations est atteint
        if (eliminationCount >= requiredEliminations)
        {
            ChangeScene();
        }
    }

    // Fonction pour changer de sc�ne
    private void ChangeScene()
    {
        Debug.Log("Changing scene to: " + nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }
}
