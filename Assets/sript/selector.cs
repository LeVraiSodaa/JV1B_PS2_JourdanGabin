using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
    // Fonction pour charger une scène spécifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(7);
    }
}
