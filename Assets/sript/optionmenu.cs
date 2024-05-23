using UnityEngine;
using UnityEngine.SceneManagement;

public class Option : MonoBehaviour
{
    // Fonction pour charger une scène spécifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(9);
    }
}

