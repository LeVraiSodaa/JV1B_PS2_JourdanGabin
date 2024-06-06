using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Fonction pour charger une scène spécifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(8);
    }
}
