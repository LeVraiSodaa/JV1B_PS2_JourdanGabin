using UnityEngine;
using UnityEngine.UI;

public class EnemyCounter : MonoBehaviour
{
    public static int enemiesKilled = 0; // Compteur d'ennemis tués
    public Text counterText; // Référence au texte affichant le compteur
    public GameObject player; // Référence au joueur

    void Start()
    {
        // Met à jour le texte affichant le compteur
        UpdateCounterText();
    }

    // Fonction appelée lorsque qu'un ennemi est tué
    public static void EnemyKilled()
    {
        // Incrémente le compteur d'ennemis tués
        enemiesKilled++;
        // Met à jour le texte affichant le compteur
        UpdateCounterText();
    }
    // Fonction pour mettre à jour le texte affichant le compteur
    static void UpdateCounterText()
    {
        // Vérifie s'il existe une instance du script dans la scène
        EnemyCounter enemyCounter = FindObjectOfType<EnemyCounter>();
        if (enemyCounter != null && enemyCounter.counterText != null)
        {
            // Met à jour le texte avec le compteur d'ennemis tués
            enemyCounter.counterText.text = "Enemies Killed: " + enemiesKilled;

            // Vérifie si le joueur a tué trois ennemis
            if (enemiesKilled >= 3)
            {
                // Active la fonctionnalité associée à la touche "W" sur le joueur
                enemyCounter.player.GetComponent<PlayerController>().EnableSpecialAbility();
            }
        }
    }
}
