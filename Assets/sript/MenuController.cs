using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    // Fonction pour charger une sc�ne sp�cifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(8);
    }
}
