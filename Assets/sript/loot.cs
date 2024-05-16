using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public static int enemiesKilled = 0; // Compteur d'ennemis tu�s
    public Text counterText; // R�f�rence au texte affichant le compteur
    public GameObject player; // R�f�rence au joueur

    void Start()
    {
        // Met � jour le texte affichant le compteur
        UpdateCounterText();
    }

    // Fonction appel�e lorsque qu'un ennemi est tu�
    public static void EnemyKilled()
    {
        // Incr�mente le compteur d'ennemis tu�s
        enemiesKilled++;
        // Met � jour le texte affichant le compteur
        UpdateCounterText();
    }
    // Fonction pour mettre � jour le texte affichant le compteur
    static void UpdateCounterText()
    {
        // V�rifie s'il existe une instance du script dans la sc�ne
        EnemyCounter enemyCounter = FindObjectOfType<EnemyCounter>();
        if (enemyCounter != null && enemyCounter.counterText != null)
        {
            // Met � jour le texte avec le compteur d'ennemis tu�s
            enemyCounter.counterText.text = "Enemies Killed: " + enemiesKilled;

            // V�rifie si le joueur a tu� trois ennemis
            if (enemiesKilled >= 3)
            {
                // Active la fonctionnalit� associ�e � la touche "W" sur le joueur
                enemyCounter.player.GetComponent<PlayerController>().EnableSpecialAbility();
            }
        }
    }
}
