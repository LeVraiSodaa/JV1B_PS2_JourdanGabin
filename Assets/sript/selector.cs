using UnityEngine;
using UnityEngine.SceneManagement;

public class selector : MonoBehaviour
{
    // Fonction pour charger une sc�ne sp�cifique
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(7);
    }
}
