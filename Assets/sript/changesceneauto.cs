using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1Controller : MonoBehaviour
{
    void Start()
    {
        // Appelle la fonction qui charge la scène 0 après 10 secondes
        Invoke("LoadScene3", 10f);
    }

    // Fonction pour charger la scène 3
    void LoadScene0()
    {
        SceneManager.LoadScene(3);
    }
}
