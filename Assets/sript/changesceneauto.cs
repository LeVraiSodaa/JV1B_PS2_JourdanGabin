using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Controller : MonoBehaviour
{
    void Start()
    {
        // Appelle la fonction qui charge la sc�ne 0 apr�s 10 secondes
        Invoke("LoadScene0", 10f);
    }

    // Fonction pour charger la sc�ne 0
    void LoadScene0()
    {
        SceneManager.LoadScene(0);
    }
}
