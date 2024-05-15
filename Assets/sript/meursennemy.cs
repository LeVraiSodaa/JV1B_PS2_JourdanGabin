using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Fonction appel�e lorsque le joueur meurt
    public void Die()
    {
        // Relance la sc�ne actuelle
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
