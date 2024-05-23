using UnityEngine;
using UnityEngine.SceneManagement;

public class goback : MonoBehaviour
{
    // Fonction pour charger une scène spécifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(2);
    }
}
