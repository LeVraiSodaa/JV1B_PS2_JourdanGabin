using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenessix : MonoBehaviour
{
    // Nom de la sc�ne � charger (peut �tre d�fini dans l'inspecteur Unity)
    public string sceneName;

    // Fonction pour charger la sc�ne sp�cifi�e
    public void LoadScene()
    {
        SceneManager.LoadScene(11);
    }
}
