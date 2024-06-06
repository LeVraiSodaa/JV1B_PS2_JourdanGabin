using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenessix : MonoBehaviour
{
    // Nom de la scène à charger (peut être défini dans l'inspecteur Unity)
    public string sceneName;

    // Fonction pour charger la scène spécifiée
    public void LoadScene()
    {
        SceneManager.LoadScene(11);
    }
}
